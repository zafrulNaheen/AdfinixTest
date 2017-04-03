using Starcounter;

namespace TestProjectAdFinix
{
    partial class FranchiseOfficesDetail : Json, IBound<FranchiseOffice>
    {

        void Handle(Input.AddFranchiseSettings action)
        {
            Db.Transact(() =>
            {
                var franchise = new FranchiseOfficeSettings()
                {
                    Franchise = (FranchiseOffice)this.Data,
                    Name = this.FranchiseSettings.Name,
                    Address = this.FranchiseSettings.Address,
                    Street = this.FranchiseSettings.Street,
                    ZipCode = this.FranchiseSettings.ZipCode,
                    Number = this.FranchiseSettings.Number,
                    City = this.FranchiseSettings.City,
                    Country = this.FranchiseSettings.Country
                };
            });
        }

        void Handle(Input.AddHomeSaleInformation action)
        {
            Db.Transact(() =>
            {
                var home = new HomeInfo()
                {
                    Franchise = (FranchiseOffice)this.Data,
                    Name = this.HomeInformation.Name,                    
                    Street = this.HomeInformation.Street,
                    ZipCode = this.HomeInformation.ZipCode,
                    Number = this.HomeInformation.Number,
                    City = this.HomeInformation.City,
                    Country = this.HomeInformation.Country
                };

                System.DateTime dt;
                System.DateTime.TryParse(this.TransactionInfo.Date, out dt);

                var homeSale = new TransactionInfo()
                {
                    SoldHome = home,
                    date = dt,
                    Commision = this.TransactionInfo.Commission,
                    SalesPrice = this.TransactionInfo.SalesPrice
                };
            });

            RefreshData();
        }

        public void RefreshData()
        {
            var Office = (FranchiseOffice)this.Data;            
            LoadFranchiseSettings(Office);
            RefreshSalesData(Office);           
        }

        void RefreshSalesData(FranchiseOffice office)
        {
            var SoldHome = office.Homes.First;
            if (SoldHome == null)
                return;

            var Transaction = SoldHome.Transcation;
            this.SoldHomeList.Clear();
            foreach (var home in office.Homes)
            {
                var trans = home.Transcation.First;

                if (trans != null)
                {
                    var sales = this.SoldHomeList.Add();
                    sales.Price = trans.SalesPrice;
                    sales.Commission = trans.Commision;
                    sales.Date = trans.date.ToShortDateString();
                    sales.Address = $"{home.Street}, {home.City}-{home.ZipCode}, {home.Country}";
                }
            }
        }

        void LoadFranchiseSettings(FranchiseOffice office)
        {            
            this.FranchiseSettings.Name = office.OfficeSettings.First.Name;
            this.FranchiseSettings.Street = office.OfficeSettings.First.Street;
            this.FranchiseSettings.Number = office.OfficeSettings.First.Number;
            this.FranchiseSettings.ZipCode = office.OfficeSettings.First.ZipCode;
            this.FranchiseSettings.Country = office.OfficeSettings.First.Country;
            this.FranchiseSettings.City = office.OfficeSettings.First.City;
        }
    }
}
