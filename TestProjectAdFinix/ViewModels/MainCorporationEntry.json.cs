using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProjectAdFinix
{
    partial class MainCorporationEntry : Json, IBound<MainCorporation>
    {
        public string CorporationNameView => Name;
      
        void Handle(Input.SaveTrigger action)
        {
            this.Transaction.Commit();  
        }
       
        void Handle(Input.AddNewFranchise action)
        {
            var franchise = new FranchiseOffice()
            {
                CorporationName = (MainCorporation)this.Data,
                Name = this.FranchiseName
            };

            this.Transaction.Commit();
            this.FranchiseName = "";
            RefreshFranchises();
        }

        public void RefreshFranchises()
        {
            var offices = this.Data.Franchises.ToList();
            BindFranchiseListView(offices);
        }

        void BindFranchiseListView(List<FranchiseOffice> offices)
        {
            this.FranchiseOffices.Clear();

            foreach (var tmpOffice in offices)
            {
                var office = this.FranchiseOffices.Add();
                office.Name = tmpOffice.Name;
                office.Link = "/TestProjectAdFinix/franchisedetails/" + tmpOffice.GetObjectID();

                office.NumberOfHomesSold = tmpOffice.NumberOfHomesSold;
                office.TotalCommission = tmpOffice.TotalCommission;
                office.AverageCommission = tmpOffice.AverageCommission;
                office.Trend = GetTrendForThisOffice(tmpOffice);
            }
        }


        decimal GetTrendForThisOffice(FranchiseOffice office)
        {
            /// get first transaction by date at the start of list
            /// asssume the first transaction, is the base value
            /// divide next transaction value with this base transaction price value
            /// this function will will return the last trend value
            
            var transactions = office.Homes.
                                        OrderBy(x => x.Transcation.First.date)
                                            .Select(y=>y.Transcation.First);
            if (transactions.Count()==0)
               return 0;
            decimal trend = 0;            
            decimal BaseValue = transactions.ElementAt(0).SalesPrice;
            foreach (var transaction in transactions)
            {
                trend = transaction.SalesPrice/BaseValue;                
            }

            return trend;
        }

        void Handle(Input.SortHouseCountTrigger  action)
        {
            var offices = this.Data.Franchises.OrderByDescending(f => f.NumberOfHomesSold).ToList();
            BindFranchiseListView(offices);
        }

        void Handle(Input.SortAvgCommissionTrigger action)
        {
            var offices = this.Data.Franchises.OrderByDescending(f => f.AverageCommission).ToList();
            BindFranchiseListView(offices);
        }

        void Handle(Input.SortTotalCommissionTrigger action)
        {
            var offices = this.Data.Franchises.OrderByDescending(f => f.TotalCommission).ToList();
            BindFranchiseListView(offices);
        }

        void Handle(Input.SortPositiveTrendTrigger action)
        {

        }
    }
}
