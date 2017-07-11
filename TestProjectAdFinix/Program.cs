using System;
using Starcounter;

namespace TestProjectAdFinix
{
    class Program
    {
        /// <summary>
        ///  new code
        /// </summary>
        static void Main()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/TestProjectAdFinix", () =>
            {
                return Db.Scope(() =>
                {
                    var corporations = Db.SQL<MainCorporation>("SELECT c FROM MainCorporation c").First;

                    var json = new MainCorporationEntry { Data = corporations };
                    json.RefreshFranchises();

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;

                    return json;
                });
            });

            Handle.GET("/TestProjectAdFinix/franchisedetails/{?}", (string id) =>
            {
                Console.WriteLine(id);
                var json = (FranchiseOfficesDetail)Self.GET("/TestProjectAdFinix/partial/franchisedetails");
                json.Data = DbHelper.FromID(DbHelper.Base64DecodeObjectID(id)) as FranchiseOffice;
                json.RefreshData();

                if (Session.Current == null)
                {
                    Session.Current = new Session(SessionOptions.PatchVersioning);
                }
                json.Session = Session.Current;

                return json;
            });

            Handle.GET("/TestProjectAdFinix/partial/franchisedetails", () => new FranchiseOfficesDetail());
        }
    }
}