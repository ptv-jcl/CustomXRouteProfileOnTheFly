using ConsoleApp19.XRoute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            #region general purpose
            var rlo = new ResultListOptions()
            {
                segments = true,
            };
            var cio = new CountryInfoOptions();
            var cc = new CallerContext()
            {
                wrappedProperties = new CallerContextProperty[]
                {
                    new CallerContextProperty() { key = "ProfileXMLSnippet", },
                    new CallerContextProperty() { key = "Profile", value = "mg-trailer-truck", },
                },
            };
            #endregion

            #region adr example
            var adrSnippet = new com.ptvgroup.xserver1.XRouteProfile.Profile()
            {
                MajorVersion = "1",
                MinorVersion = "0",
                DataCompatibilityVersion = "2",
                FeatureLayer = new com.ptvgroup.xserver1.XRouteProfile.FeatureLayer()
                {
                    MajorVersion = "1",
                    MinorVersion = "0",
                    GlobalSettings = new com.ptvgroup.xserver1.XRouteProfile.GlobalSettings()
                    {
                        EnableVehicleDependency = "true",
                    },
                    Themes = new com.ptvgroup.xserver1.XRouteProfile.Themes()
                    {
                        Theme = new List<com.ptvgroup.xserver1.XRouteProfile.Theme>()
                        {
                            new com.ptvgroup.xserver1.XRouteProfile.Theme()
                            {
                                Enabled = "true",
                                Id = "PTV_TruckAttributes",
                            },
                        },
                    },
                },
                Routing = new com.ptvgroup.xserver1.XRouteProfile.Routing()
                {
                    MajorVersion = "2",
                    MinorVersion = "0",
                    Vehicle = new com.ptvgroup.xserver1.XRouteProfile.Vehicle()
                    {
                        Load = new com.ptvgroup.xserver1.XRouteProfile.Load()
                        {
                            LoadType = "GOODS",
                            HazardousGoodsType = "HAZARDOUS",
                            TunnelRestrictionCode = "E",
                        },
                    },
                    Course = new com.ptvgroup.xserver1.XRouteProfile.Course()
                    {
                        AdditionalDataRules = new com.ptvgroup.xserver1.XRouteProfile.AdditionalDataRules()
                        {
                            Enabled = "true",
                        },
                    },
                }
            };
            var tunnelWps = new WaypointDesc[]
            {
                new WaypointDesc()
                {
                    linkType = LinkType.AUTO_LINKING,
                    wrappedCoords = new Point[]
                    {
                        new Point() { point = new PlainPoint() { x = 520127, y = 6878446, }, },
                    },
                },
                new WaypointDesc()
                {
                    linkType = LinkType.AUTO_LINKING,
                    wrappedCoords = new Point[]
                    {
                        new Point() { point = new PlainPoint() { x = 522578, y = 6861984, }, },
                    },
                },
            };
            #endregion

            #region block country
            var blockBelgiumSnippet = new com.ptvgroup.xserver1.XRouteProfile.Profile()
            {
                MajorVersion = "1",
                MinorVersion = "0",
                DataCompatibilityVersion = "2",
                Routing = new com.ptvgroup.xserver1.XRouteProfile.Routing()
                {
                    MajorVersion = "2",
                    MinorVersion = "0",
                    Algorithm = new com.ptvgroup.xserver1.XRouteProfile.Algorithm()
                    {
                        GeographicRestrictions = new com.ptvgroup.xserver1.XRouteProfile.GeographicRestrictions()
                        {
                            ForbiddenCountry = new List<com.ptvgroup.xserver1.XRouteProfile.ForbiddenCountry>()
                            {
                                new com.ptvgroup.xserver1.XRouteProfile.ForbiddenCountry() { CountryCode = "32", },
                            },
                        },
                    },
                },
            };
            var normallyThroughBelgiumWps = new WaypointDesc[]
            {
                new WaypointDesc()
                {
                    linkType = LinkType.AUTO_LINKING,
                    wrappedCoords = new Point[]
                    {
                        new Point() { point = new PlainPoint() { x = 510724, y = 6734625, }, },
                    },
                },
                new WaypointDesc()
                {
                    linkType = LinkType.AUTO_LINKING,
                    wrappedCoords = new Point[]
                    {
                        new Point() { point = new PlainPoint() { x = 290832, y = 6514732, }, },
                    },
                },
            };
            #endregion

            #region emissions
            var emmisionSnippet = new com.ptvgroup.xserver1.XRouteProfile.Profile()
            {
                MajorVersion = "1",
                MinorVersion = "0",
                DataCompatibilityVersion = "2",
                Routing = new com.ptvgroup.xserver1.XRouteProfile.Routing()
                {
                    MajorVersion = "2",
                    MinorVersion = "0",
                    Vehicle = new com.ptvgroup.xserver1.XRouteProfile.Vehicle()
                    {
                        Physical = new com.ptvgroup.xserver1.XRouteProfile.Physical()
                        {
                            Drive = new com.ptvgroup.xserver1.XRouteProfile.Drive()
                            {
                                DriveType = "MOTORIZED",
                                Emissions = new com.ptvgroup.xserver1.XRouteProfile.Emissions()
                                {
                                    EmissionClass = "EURO_6",
                                },
                                Engine = new com.ptvgroup.xserver1.XRouteProfile.Engine()
                                {
                                    BioFuelRatio = "0",
                                    FuelConsumption = "32.6",
                                    FuelType = "DIESEL",
                                }
                            }
                        }
                    },
                },
            };
            var emmisionWps = new WaypointDesc[]
            {
                new WaypointDesc()
                {
                    linkType = LinkType.AUTO_LINKING,
                    wrappedCoords = new Point[]
                    {
                        new Point() { point = new PlainPoint() { x = 735099, y = 6755798, }, },
                    },
                },
                new WaypointDesc()
                {
                    linkType = LinkType.AUTO_LINKING,
                    wrappedCoords = new Point[]
                    {
                        new Point() { point = new PlainPoint() { x = 1350798, y = 6074131, }, },
                    },
                },
            };

            var emmissionsRlo = new ResultListOptions()
            {
                emissions = new EmissionType() { emissionLevel = EmissionLevel.BASIC, },
                hbefaType = new HBEFAType() { version = HBEFAVersion.HBEFA_3_2, },
                cenEmissionConfiguration = new CENEmissionConfiguration()
                {
                    cenVersion = CENVersion.CEN_2012,
                    fleetSpecificAverageFuelConsumption = 32.6,
                    fleetSpecificAverageFuelConsumptionSpecified = true,
                },
            };
            #endregion

            using (var xroute = new XRouteWSClient())
            {
                //var binding = xroute.Endpoint.Binding as BasicHttpBinding;
                //binding.Security.Mode = BasicHttpSecurityMode.Transport;
                //binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
                //binding.MaxReceivedMessageSize = 1234567890;
                //xroute.ClientCredentials.UserName.UserName = "xtok";
                //xroute.ClientCredentials.UserName.Password = "";
                //xroute.Endpoint.Address = new EndpointAddress("https://xroute-tln-eu-n.cloud.ptvgroup.com/xroute/ws/XRoute");

                ExtendedRoute extendedRoute = null;

                Console.WriteLine(blockBelgiumSnippet.ToSnippet());
                                
                extendedRoute = xroute.calculateExtendedRoute(normallyThroughBelgiumWps, null, null, rlo, cio, cc);
                Console.WriteLine($"Withouth \"block belgium\" snippet the distance is {extendedRoute.route.info.distance}. It goes through {string.Join(",", extendedRoute.route.wrappedSegments.Select(s => s.iuCode).Distinct())}");

                cc.wrappedProperties[0].value = blockBelgiumSnippet.ToSnippet();
                extendedRoute = xroute.calculateExtendedRoute(normallyThroughBelgiumWps, null, null, rlo, cio, cc);
                Console.WriteLine($"Withouth \"block belgium\" snippet the distance is {extendedRoute.route.info.distance}. It goes through {string.Join(",", extendedRoute.route.wrappedSegments.Select(s => s.iuCode).Distinct())}");

                Console.WriteLine();
                Console.WriteLine(emmisionSnippet.ToSnippet());

                cc.wrappedProperties[0].value = emmisionSnippet.ToSnippet();
                extendedRoute = xroute.calculateExtendedRoute(emmisionWps, null, null, emmissionsRlo, cio, cc);
                Console.WriteLine($"Emmisison distance {extendedRoute.route.info.distance}. Fleet based co2eTank2Wheel = {(extendedRoute.route.cenEmissions.fleetSpecific as CENEmissions2012).co2eTank2Wheel}. HBEFA based co2eTank2Wheel = {(extendedRoute.route.cenEmissions.basedOnHBEFA as CENEmissions2012).co2eTank2Wheel}. Pure HBEFA carbonDioxide = {extendedRoute.route.emissions.carbonDioxide} ");

                Console.WriteLine();
                Console.WriteLine(adrSnippet.ToSnippet());

                cc.wrappedProperties[0].value = adrSnippet.ToSnippet();
                extendedRoute = xroute.calculateExtendedRoute(tunnelWps, null, null, rlo, cio, cc);
                Console.WriteLine($"With tunnel code {adrSnippet.Routing.Vehicle.Load.TunnelRestrictionCode} the distance is {extendedRoute.route.info.distance}.");

                adrSnippet.Routing.Vehicle.Load.TunnelRestrictionCode = "D";
                cc.wrappedProperties[0].value = adrSnippet.ToSnippet();
                extendedRoute = xroute.calculateExtendedRoute(tunnelWps, null, null, rlo, cio, cc);
                Console.WriteLine($"With tunnel code {adrSnippet.Routing.Vehicle.Load.TunnelRestrictionCode} the distance is {extendedRoute.route.info.distance}.");

                adrSnippet.Routing.Vehicle.Load.TunnelRestrictionCode = "C";
                cc.wrappedProperties[0].value = adrSnippet.ToSnippet();
                extendedRoute = xroute.calculateExtendedRoute(tunnelWps, null, null, rlo, cio, cc);
                Console.WriteLine($"With tunnel code {adrSnippet.Routing.Vehicle.Load.TunnelRestrictionCode} the distance is {extendedRoute.route.info.distance}.");

                adrSnippet.Routing.Vehicle.Load.TunnelRestrictionCode = "B";
                cc.wrappedProperties[0].value = adrSnippet.ToSnippet();
                extendedRoute = xroute.calculateExtendedRoute(tunnelWps, null, null, rlo, cio, cc);
                Console.WriteLine($"With tunnel code {adrSnippet.Routing.Vehicle.Load.TunnelRestrictionCode} the distance is {extendedRoute.route.info.distance}.");

                adrSnippet.Routing.Vehicle.Load.TunnelRestrictionCode = "NONE";
                cc.wrappedProperties[0].value = adrSnippet.ToSnippet();
                extendedRoute = xroute.calculateExtendedRoute(tunnelWps, null, null, rlo, cio, cc);
                Console.WriteLine($"With tunnel code {adrSnippet.Routing.Vehicle.Load.TunnelRestrictionCode} the distance is {extendedRoute.route.info.distance}.");
            }
            Console.ReadLine();
        }
    }
}
