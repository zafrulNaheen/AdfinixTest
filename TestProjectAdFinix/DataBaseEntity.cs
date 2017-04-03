using System;
using Starcounter;
using System.Collections.Generic;

namespace TestProjectAdFinix
{
 
    [Database]
    public class MainCorporation
    {
        public string Name;
        public QueryResultRows<FranchiseOffice> Franchises => Db.SQL<FranchiseOffice>("SELECT e FROM TestProjectAdFinix.FranchiseOffice e where e.CorporationName = ?", this);        
    }

    [Database]
    public class CorporationList
    {
        public QueryResultRows<MainCorporation> Corporations => Db.SQL<MainCorporation>("SELECT * FROM TestProjectAdFinix.MainCorporation");        
    }

    [Database]
    public class FranchiseOffice
    {
        public string Name;
        
        public MainCorporation CorporationName;

        public QueryResultRows<FranchiseOfficeSettings> OfficeSettings => Db.SQL<FranchiseOfficeSettings>("SELECT e FROM TestProjectAdFinix.FranchiseOfficeSettings e WHERE e.Franchise = ?", this);

        public QueryResultRows<HomeInfo> Homes => Db.SQL<HomeInfo>("SELECT e FROM TestProjectAdFinix.HomeInfo e WHERE e.Franchise = ?", this);

        public long NumberOfHomesSold => Db.SQL<long>("SELECT Count(e) FROM TestProjectAdFinix.HomeInfo e INNER JOIN TestProjectAdFinix.TransactionInfo d ON e = d.SoldHome WHERE e.Franchise = ?", this).First ;

        public decimal TotalCommission => Db.SQL<decimal>("SELECT SUM(d.Commision) FROM TestProjectAdFinix.HomeInfo e INNER JOIN TestProjectAdFinix.TransactionInfo d ON e = d.SoldHome WHERE e.Franchise = ?", this).First;

        public decimal AverageCommission => this.TotalCommission==0?0: this.TotalCommission / this.NumberOfHomesSold; 

    }

    [Database]
    public class FranchiseOfficeSettings
    {
        public FranchiseOffice Franchise;

        public string Name;
        public string Street;
        public string Number;
        public string ZipCode;
        public string City;
        public string Country;
        public string Address;        
    }

    [Database]
    public class HomeInfo
    {
        public FranchiseOffice Franchise;
        public QueryResultRows<TransactionInfo> Transcation => Db.SQL<TransactionInfo>("SELECT e FROM TestProjectAdFinix.TransactionInfo e WHERE e.SoldHome = ?", this);

        public string Name;
        public string Street;
        public string Number;
        public string ZipCode;
        public string City;
        public string Country;
    }

    [Database]
    public class TransactionInfo
    {
        public HomeInfo SoldHome;

        public DateTime date;
        public decimal SalesPrice;
        public decimal Commision;
        
    }
}
