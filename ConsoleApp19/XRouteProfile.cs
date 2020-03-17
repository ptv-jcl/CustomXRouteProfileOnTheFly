using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace com.ptvgroup.xserver1.XRouteProfile
{
    [XmlRoot(ElementName = "Common")]
    public class Common
    {
        [XmlAttribute(AttributeName = "coordinateFormat")]
        public string CoordinateFormat { get; set; }
        [XmlAttribute(AttributeName = "language")]
        public string Language { get; set; }
        [XmlAttribute(AttributeName = "majorVersion")]
        public string MajorVersion { get; set; }
        [XmlAttribute(AttributeName = "minorVersion")]
        public string MinorVersion { get; set; }
    }

    [XmlRoot(ElementName = "Road")]
    public class Road
    {
        [XmlAttribute(AttributeName = "headingTolerance")]
        public string HeadingTolerance { get; set; }
        [XmlAttribute(AttributeName = "maximumDistanceForNetworkClass0")]
        public string MaximumDistanceForNetworkClass0 { get; set; }
        [XmlAttribute(AttributeName = "maximumNetworkClass")]
        public string MaximumNetworkClass { get; set; }
        [XmlAttribute(AttributeName = "minimumNetworkClass")]
        public string MinimumNetworkClass { get; set; }
        [XmlAttribute(AttributeName = "onlyReachableRoads")]
        public string OnlyReachableRoads { get; set; }
    }

    [XmlRoot(ElementName = "Smart")]
    public class Smart
    {
        [XmlAttribute(AttributeName = "checkNetworkClassOnlyForVias")]
        public string CheckNetworkClassOnlyForVias { get; set; }
        [XmlAttribute(AttributeName = "maximumDistanceToMainNode")]
        public string MaximumDistanceToMainNode { get; set; }
        [XmlAttribute(AttributeName = "maximumDistanceToMainNodeForNetworkClass0")]
        public string MaximumDistanceToMainNodeForNetworkClass0 { get; set; }
    }

    [XmlRoot(ElementName = "TollStation")]
    public class TollStation
    {
        [XmlAttribute(AttributeName = "maximumDistance")]
        public string MaximumDistance { get; set; }
    }

    [XmlRoot(ElementName = "RoadName")]
    public class RoadName
    {
        [XmlAttribute(AttributeName = "maximumDistance")]
        public string MaximumDistance { get; set; }
        [XmlAttribute(AttributeName = "maximumDistanceToMainNode")]
        public string MaximumDistanceToMainNode { get; set; }
    }

    [XmlRoot(ElementName = "LinkTypeConfiguration")]
    public class LinkTypeConfiguration
    {
        [XmlElement(ElementName = "Road")]
        public Road Road { get; set; }
        [XmlElement(ElementName = "Smart")]
        public Smart Smart { get; set; }
        [XmlElement(ElementName = "TollStation")]
        public TollStation TollStation { get; set; }
        [XmlElement(ElementName = "RoadName")]
        public RoadName RoadName { get; set; }
    }

    [XmlRoot(ElementName = "Waypoint")]
    public class Waypoint
    {
        [XmlElement(ElementName = "LinkTypeConfiguration")]
        public LinkTypeConfiguration LinkTypeConfiguration { get; set; }
        [XmlAttribute(AttributeName = "linkType")]
        public string LinkType { get; set; }
        [XmlAttribute(AttributeName = "maximumDistanceToCombinedTransport")]
        public string MaximumDistanceToCombinedTransport { get; set; }
        [XmlAttribute(AttributeName = "maximumDistanceToSegment")]
        public string MaximumDistanceToSegment { get; set; }
    }

    [XmlRoot(ElementName = "LevellingScopeByNetworkClass")]
    public class LevellingScopeByNetworkClass
    {
        [XmlAttribute(AttributeName = "searchSpace")]
        public string SearchSpace { get; set; }
    }

    [XmlRoot(ElementName = "CustomBoundingBox")]
    public class CustomBoundingBox
    {
        [XmlAttribute(AttributeName = "bottom")]
        public string Bottom { get; set; }
        [XmlAttribute(AttributeName = "left")]
        public string Left { get; set; }
        [XmlAttribute(AttributeName = "right")]
        public string Right { get; set; }
        [XmlAttribute(AttributeName = "top")]
        public string Top { get; set; }
    }

    [XmlRoot(ElementName = "BoundingBox")]
    public class BoundingBox
    {
        [XmlElement(ElementName = "CustomBoundingBox")]
        public CustomBoundingBox CustomBoundingBox { get; set; }
        [XmlAttribute(AttributeName = "boundingBoxExtension")]
        public string BoundingBoxExtension { get; set; }
        [XmlAttribute(AttributeName = "restrictionMode")]
        public string RestrictionMode { get; set; }
        [XmlAttribute(AttributeName = "aspectRatio")]
        public string AspectRatio { get; set; }
        [XmlAttribute(AttributeName = "calculateBoundingBoxes")]
        public string CalculateBoundingBoxes { get; set; }
        [XmlAttribute(AttributeName = "offset")]
        public string Offset { get; set; }
    }

    [XmlRoot(ElementName = "GeographicRestrictions")]
    public class GeographicRestrictions
    {
        [XmlElement(ElementName = "BoundingBox")]
        public BoundingBox BoundingBox { get; set; }
        [XmlElement(ElementName = "AllowedCountry")]
        public List<AllowedCountry> AllowedCountry { get; set; }
        [XmlElement(ElementName = "ForbiddenCountry")]
        public List<ForbiddenCountry> ForbiddenCountry { get; set; }

    }

    [XmlRoot(ElementName = "AllowedCountry")]
    public class AllowedCountry
    {
        [XmlAttribute(AttributeName = "countryCode")]
        public string CountryCode { get; set; }
    }

    [XmlRoot(ElementName = "ForbiddenCountry")]
    public class ForbiddenCountry
    {
        [XmlAttribute(AttributeName = "countryCode")]
        public string CountryCode { get; set; }
    }

    [XmlRoot(ElementName = "Algorithm")]
    public class Algorithm
    {
        [XmlElement(ElementName = "LevellingScopeByNetworkClass")]
        public List<LevellingScopeByNetworkClass> LevellingScopeByNetworkClass { get; set; }
        [XmlElement(ElementName = "GeographicRestrictions")]
        public GeographicRestrictions GeographicRestrictions { get; set; }
        [XmlAttribute(AttributeName = "aStarAggressiveness")]
        public string AStarAggressiveness { get; set; }
        [XmlAttribute(AttributeName = "routingAlgorithm")]
        public string RoutingAlgorithm { get; set; }
        [XmlAttribute(AttributeName = "useFastTurningBanHeuristic")]
        public string UseFastTurningBanHeuristic { get; set; }
    }

    [XmlRoot(ElementName = "AuthorizedVehicles")]
    public class AuthorizedVehicles
    {
        [XmlAttribute(AttributeName = "turningBanCost")]
        public string TurningBanCost { get; set; }
    }

    [XmlRoot(ElementName = "DeliveryVehicles")]
    public class DeliveryVehicles
    {
        [XmlAttribute(AttributeName = "segmentMalus")]
        public string SegmentMalus { get; set; }
    }

    [XmlRoot(ElementName = "EmergencyVehicles")]
    public class EmergencyVehicles
    {
        [XmlAttribute(AttributeName = "segmentMalus")]
        public string SegmentMalus { get; set; }
        [XmlAttribute(AttributeName = "turningBanCost")]
        public string TurningBanCost { get; set; }
    }

    [XmlRoot(ElementName = "ProjectSpecificVehicles")]
    public class ProjectSpecificVehicles
    {
        [XmlAttribute(AttributeName = "blockedSegmentMalus")]
        public string BlockedSegmentMalus { get; set; }
        [XmlAttribute(AttributeName = "openSegmentMalus")]
        public string OpenSegmentMalus { get; set; }
        [XmlAttribute(AttributeName = "turningBanCost")]
        public string TurningBanCost { get; set; }
    }

    [XmlRoot(ElementName = "VehicleSpecific")]
    public class VehicleSpecific
    {
        [XmlElement(ElementName = "AuthorizedVehicles")]
        public AuthorizedVehicles AuthorizedVehicles { get; set; }
        [XmlElement(ElementName = "DeliveryVehicles")]
        public DeliveryVehicles DeliveryVehicles { get; set; }
        [XmlElement(ElementName = "EmergencyVehicles")]
        public EmergencyVehicles EmergencyVehicles { get; set; }
        [XmlElement(ElementName = "ProjectSpecificVehicles")]
        public ProjectSpecificVehicles ProjectSpecificVehicles { get; set; }
        [XmlElement(ElementName = "Malus")]
        public Malus Malus { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "Blockings")]
    public class Blockings
    {
        [XmlAttribute(AttributeName = "blockedInWinterMalus")]
        public string BlockedInWinterMalus { get; set; }
        [XmlAttribute(AttributeName = "blockedMalus")]
        public string BlockedMalus { get; set; }
        [XmlAttribute(AttributeName = "blockedTimeDependentMalus")]
        public string BlockedTimeDependentMalus { get; set; }
        [XmlAttribute(AttributeName = "oppositeDirectionInOneWayRoadMalus")]
        public string OppositeDirectionInOneWayRoadMalus { get; set; }
    }

    [XmlRoot(ElementName = "MalusByNetworkClass")]
    public class MalusByNetworkClass
    {
        [XmlAttribute(AttributeName = "malus")]
        public string Malus { get; set; }
    }

    [XmlRoot(ElementName = "Network")]
    public class Network
    {
        [XmlElement(ElementName = "MalusByNetworkClass")]
        public List<MalusByNetworkClass> MalusByNetworkClass { get; set; }
        [XmlAttribute(AttributeName = "rampMalus")]
        public string RampMalus { get; set; }
    }

    [XmlRoot(ElementName = "Toll")]
    public class Toll
    {
        [XmlAttribute(AttributeName = "extraTollMalus")]
        public string ExtraTollMalus { get; set; }
        [XmlAttribute(AttributeName = "tollMalus")]
        public string TollMalus { get; set; }
        [XmlAttribute(AttributeName = "vignetteMalus")]
        public string VignetteMalus { get; set; }
    }

    [XmlRoot(ElementName = "SpecialAreas")]
    public class SpecialAreas
    {
        [XmlAttribute(AttributeName = "forbiddenLowEmissionZoneMalus")]
        public string ForbiddenLowEmissionZoneMalus { get; set; }
        [XmlAttribute(AttributeName = "minimumUrbanNetworkClass")]
        public string MinimumUrbanNetworkClass { get; set; }
        [XmlAttribute(AttributeName = "residentialMalus")]
        public string ResidentialMalus { get; set; }
        [XmlAttribute(AttributeName = "urbanMalus")]
        public string UrbanMalus { get; set; }
    }

    [XmlRoot(ElementName = "CombinedTransport")]
    public class CombinedTransport
    {
        [XmlAttribute(AttributeName = "blockedFerryMalus")]
        public string BlockedFerryMalus { get; set; }
        [XmlAttribute(AttributeName = "ferryMalus")]
        public string FerryMalus { get; set; }
        [XmlAttribute(AttributeName = "piggybackMalus")]
        public string PiggybackMalus { get; set; }
    }

    [XmlRoot(ElementName = "BasicDataRules")]
    public class BasicDataRules
    {
        [XmlElement(ElementName = "VehicleSpecific")]
        public VehicleSpecific VehicleSpecific { get; set; }
        [XmlElement(ElementName = "Blockings")]
        public Blockings Blockings { get; set; }
        [XmlElement(ElementName = "Network")]
        public Network Network { get; set; }
        [XmlElement(ElementName = "Toll")]
        public Toll Toll { get; set; }
        [XmlElement(ElementName = "SpecialAreas")]
        public SpecialAreas SpecialAreas { get; set; }
        [XmlElement(ElementName = "CombinedTransport")]
        public CombinedTransport CombinedTransport { get; set; }
    }

    [XmlRoot(ElementName = "SegmentSpecific")]
    public class SegmentSpecific
    {
        [XmlAttribute(AttributeName = "useBlockedForCarsAttribute")]
        public string UseBlockedForCarsAttribute { get; set; }
        [XmlAttribute(AttributeName = "useBlockedForTrucksAttribute")]
        public string UseBlockedForTrucksAttribute { get; set; }
        [XmlAttribute(AttributeName = "useFerryDuration")]
        public string UseFerryDuration { get; set; }
        [XmlAttribute(AttributeName = "useFerryLength")]
        public string UseFerryLength { get; set; }
        [XmlAttribute(AttributeName = "useRampAttribute")]
        public string UseRampAttribute { get; set; }
        [XmlAttribute(AttributeName = "useSegmentLength")]
        public string UseSegmentLength { get; set; }
        [XmlAttribute(AttributeName = "useSpeed")]
        public string UseSpeed { get; set; }
        [XmlAttribute(AttributeName = "useTollForCarsAttribute")]
        public string UseTollForCarsAttribute { get; set; }
        [XmlAttribute(AttributeName = "useTollForTrucksAttribute")]
        public string UseTollForTrucksAttribute { get; set; }
        [XmlAttribute(AttributeName = "useUrbanAttribute")]
        public string UseUrbanAttribute { get; set; }
    }

    [XmlRoot(ElementName = "Malus")]
    public class Malus
    {
        [XmlAttribute(AttributeName = "combustibles")]
        public string Combustibles { get; set; }
        [XmlAttribute(AttributeName = "delivery")]
        public string Delivery { get; set; }
        [XmlAttribute(AttributeName = "hazardousGoods")]
        public string HazardousGoods { get; set; }
        [XmlAttribute(AttributeName = "hazardousToWaters")]
        public string HazardousToWaters { get; set; }
        [XmlAttribute(AttributeName = "maintenanceTrucks")]
        public string MaintenanceTrucks { get; set; }
        [XmlAttribute(AttributeName = "preferredForHazardousGoods")]
        public string PreferredForHazardousGoods { get; set; }
        [XmlAttribute(AttributeName = "preferredForTrucks")]
        public string PreferredForTrucks { get; set; }
        [XmlAttribute(AttributeName = "residential")]
        public string Residential { get; set; }
        [XmlAttribute(AttributeName = "restrictedTunnel")]
        public string RestrictedTunnel { get; set; }
        [XmlAttribute(AttributeName = "vehiclesWithTrailer")]
        public string VehiclesWithTrailer { get; set; }
    }

    [XmlRoot(ElementName = "AdditionalDataRules")]
    public class AdditionalDataRules
    {
        [XmlElement(ElementName = "SegmentSpecific")]
        public SegmentSpecific SegmentSpecific { get; set; }
        [XmlElement(ElementName = "VehicleSpecific")]
        public VehicleSpecific VehicleSpecific { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
        [XmlAttribute(AttributeName = "layerName")]
        public string LayerName { get; set; }
    }

    [XmlRoot(ElementName = "SpeedMapping")]
    public class SpeedMapping
    {
        [XmlAttribute(AttributeName = "baseSpeed")]
        public string BaseSpeed { get; set; }
        [XmlAttribute(AttributeName = "mappedSpeed")]
        public string MappedSpeed { get; set; }
    }

    [XmlRoot(ElementName = "DynamicTimeStep")]
    public class DynamicTimeStep
    {
        [XmlAttribute(AttributeName = "count")]
        public string Count { get; set; }
        [XmlAttribute(AttributeName = "size")]
        public string Size { get; set; }
    }

    [XmlRoot(ElementName = "DynamicRouting")]
    public class DynamicRouting
    {
        [XmlElement(ElementName = "SpeedMapping")]
        public List<SpeedMapping> SpeedMapping { get; set; }
        [XmlElement(ElementName = "DynamicTimeStep")]
        public DynamicTimeStep DynamicTimeStep { get; set; }
        [XmlAttribute(AttributeName = "breakCalculationPrecision")]
        public string BreakCalculationPrecision { get; set; }
        [XmlAttribute(AttributeName = "dynamicTimeOnStaticRoute")]
        public string DynamicTimeOnStaticRoute { get; set; }
        [XmlAttribute(AttributeName = "layerName")]
        public string LayerName { get; set; }
        [XmlAttribute(AttributeName = "limitDynamicSpeedToStaticSpeed")]
        public string LimitDynamicSpeedToStaticSpeed { get; set; }
        [XmlAttribute(AttributeName = "useFreeFlowSpeed")]
        public string UseFreeFlowSpeed { get; set; }
        [XmlAttribute(AttributeName = "useLegacyDynamic")]
        public string UseLegacyDynamic { get; set; }
    }

    [XmlRoot(ElementName = "Maneuver")]
    public class Maneuver
    {
        [XmlAttribute(AttributeName = "considerTurningBans")]
        public string ConsiderTurningBans { get; set; }
        [XmlAttribute(AttributeName = "uTurnCost")]
        public string UTurnCost { get; set; }
    }

    [XmlRoot(ElementName = "SegmentBlockingViolations")]
    public class SegmentBlockingViolations
    {
        [XmlAttribute(AttributeName = "cost")]
        public string Cost { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "Violations")]
    public class Violations
    {
        [XmlElement(ElementName = "SegmentBlockingViolations")]
        public SegmentBlockingViolations SegmentBlockingViolations { get; set; }
    }

    [XmlRoot(ElementName = "Course")]
    public class Course
    {
        [XmlElement(ElementName = "BasicDataRules")]
        public BasicDataRules BasicDataRules { get; set; }
        [XmlElement(ElementName = "AdditionalDataRules")]
        public AdditionalDataRules AdditionalDataRules { get; set; }
        [XmlElement(ElementName = "DynamicRouting")]
        public DynamicRouting DynamicRouting { get; set; }
        [XmlElement(ElementName = "Maneuver")]
        public Maneuver Maneuver { get; set; }
        [XmlElement(ElementName = "Violations")]
        public Violations Violations { get; set; }
        [XmlAttribute(AttributeName = "distanceTimeWeighting")]
        public string DistanceTimeWeighting { get; set; }
        [XmlAttribute(AttributeName = "enforceShortestRoute")]
        public string EnforceShortestRoute { get; set; }
    }

    [XmlRoot(ElementName = "Emissions")]
    public class Emissions
    {
        [XmlAttribute(AttributeName = "emissionClass")]
        public string EmissionClass { get; set; }
        [XmlAttribute(AttributeName = "emissionTechnology")]
        public string EmissionTechnology { get; set; }
        [XmlAttribute(AttributeName = "lowEmissionZoneType")]
        public string LowEmissionZoneType { get; set; }
        [XmlAttribute(AttributeName = "particleFilterInstalled")]
        public string ParticleFilterInstalled { get; set; }
        [XmlAttribute(AttributeName = "particleReductionClass")]
        public string ParticleReductionClass { get; set; }
    }

    [XmlRoot(ElementName = "Engine")]
    public class Engine
    {
        [XmlAttribute(AttributeName = "bioFuelRatio")]
        public string BioFuelRatio { get; set; }
        [XmlAttribute(AttributeName = "cylinderCapacity")]
        public string CylinderCapacity { get; set; }
        [XmlAttribute(AttributeName = "fuelConsumption")]
        public string FuelConsumption { get; set; }
        [XmlAttribute(AttributeName = "fuelType")]
        public string FuelType { get; set; }
    }

    [XmlRoot(ElementName = "Drive")]
    public class Drive
    {
        [XmlElement(ElementName = "Emissions")]
        public Emissions Emissions { get; set; }
        [XmlElement(ElementName = "Engine")]
        public Engine Engine { get; set; }
        [XmlAttribute(AttributeName = "driveType")]
        public string DriveType { get; set; }
    }

    [XmlRoot(ElementName = "Weight")]
    public class Weight
    {
        [XmlAttribute(AttributeName = "emptyWeight")]
        public string EmptyWeight { get; set; }
        [XmlAttribute(AttributeName = "loadWeight")]
        public string LoadWeight { get; set; }
        [XmlAttribute(AttributeName = "totalPermittedWeight")]
        public string TotalPermittedWeight { get; set; }
    }

    [XmlRoot(ElementName = "Axle")]
    public class Axle
    {
        [XmlAttribute(AttributeName = "axleLoad")]
        public string AxleLoad { get; set; }
        [XmlAttribute(AttributeName = "numberOfAxles")]
        public string NumberOfAxles { get; set; }
    }

    [XmlRoot(ElementName = "Trailer")]
    public class Trailer
    {
        [XmlAttribute(AttributeName = "emptyWeight")]
        public string EmptyWeight { get; set; }
    }

    [XmlRoot(ElementName = "Passenger")]
    public class Passenger
    {
        [XmlAttribute(AttributeName = "maximumPermittedNumberOfPassengers")]
        public string MaximumPermittedNumberOfPassengers { get; set; }
    }

    [XmlRoot(ElementName = "Dimension")]
    public class Dimension
    {
        [XmlAttribute(AttributeName = "height")]
        public string Height { get; set; }
        [XmlAttribute(AttributeName = "heightAboveFrontAxle")]
        public string HeightAboveFrontAxle { get; set; }
        [XmlAttribute(AttributeName = "length")]
        public string Length { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
    }

    [XmlRoot(ElementName = "Physical")]
    public class Physical
    {
        [XmlElement(ElementName = "Drive")]
        public Drive Drive { get; set; }
        [XmlElement(ElementName = "Weight")]
        public Weight Weight { get; set; }
        [XmlElement(ElementName = "Axle")]
        public Axle Axle { get; set; }
        [XmlElement(ElementName = "Trailer")]
        public Trailer Trailer { get; set; }
        [XmlElement(ElementName = "Passenger")]
        public Passenger Passenger { get; set; }
        [XmlElement(ElementName = "Dimension")]
        public Dimension Dimension { get; set; }
    }

    [XmlRoot(ElementName = "LegalCondition")]
    public class LegalCondition
    {
        [XmlAttribute(AttributeName = "isAuthorized")]
        public string IsAuthorized { get; set; }
        [XmlAttribute(AttributeName = "isDelivery")]
        public string IsDelivery { get; set; }
        [XmlAttribute(AttributeName = "isEmergency")]
        public string IsEmergency { get; set; }
        [XmlAttribute(AttributeName = "isMaintenance")]
        public string IsMaintenance { get; set; }
        [XmlAttribute(AttributeName = "isProject")]
        public string IsProject { get; set; }
    }

    [XmlRoot(ElementName = "Legal")]
    public class Legal
    {
        [XmlElement(ElementName = "LegalCondition")]
        public LegalCondition LegalCondition { get; set; }
        [XmlAttribute(AttributeName = "yearOfManufacture")]
        public string YearOfManufacture { get; set; }
    }

    [XmlRoot(ElementName = "Load")]
    public class Load
    {
        [XmlAttribute(AttributeName = "hazardousGoodsType")]
        public string HazardousGoodsType { get; set; }
        [XmlAttribute(AttributeName = "loadType")]
        public string LoadType { get; set; }
        [XmlAttribute(AttributeName = "tunnelRestrictionCode")]
        public string TunnelRestrictionCode { get; set; }
    }

    [XmlRoot(ElementName = "SpeedRangeByNetworkClass")]
    public class SpeedRangeByNetworkClass
    {
        [XmlAttribute(AttributeName = "maximumSpeed")]
        public string MaximumSpeed { get; set; }
        [XmlAttribute(AttributeName = "minimumSpeed")]
        public string MinimumSpeed { get; set; }
    }

    [XmlRoot(ElementName = "Speed")]
    public class Speed
    {
        [XmlElement(ElementName = "SpeedRangeByNetworkClass")]
        public List<SpeedRangeByNetworkClass> SpeedRangeByNetworkClass { get; set; }
        [XmlAttribute(AttributeName = "maximumSpeed")]
        public string MaximumSpeed { get; set; }
        [XmlAttribute(AttributeName = "speedForAirLineDistance")]
        public string SpeedForAirLineDistance { get; set; }
    }

    [XmlRoot(ElementName = "Vehicle")]
    public class Vehicle
    {
        [XmlElement(ElementName = "Physical")]
        public Physical Physical { get; set; }
        [XmlElement(ElementName = "Legal")]
        public Legal Legal { get; set; }
        [XmlElement(ElementName = "Load")]
        public Load Load { get; set; }
        [XmlElement(ElementName = "Speed")]
        public Speed Speed { get; set; }
    }

    [XmlRoot(ElementName = "SumUpNetworkClass")]
    public class SumUpNetworkClass
    {
        [XmlAttribute(AttributeName = "sumUp")]
        public string SumUp { get; set; }
    }

    [XmlRoot(ElementName = "Matrix")]
    public class Matrix
    {
        [XmlElement(ElementName = "SumUpNetworkClass")]
        public List<SumUpNetworkClass> SumUpNetworkClass { get; set; }
        [XmlAttribute(AttributeName = "distanceLimit")]
        public string DistanceLimit { get; set; }
        [XmlAttribute(AttributeName = "onlyTollRoads")]
        public string OnlyTollRoads { get; set; }
        [XmlAttribute(AttributeName = "timeLimit")]
        public string TimeLimit { get; set; }
    }

    [XmlRoot(ElementName = "TileBasedPolygon")]
    public class TileBasedPolygon
    {
        [XmlAttribute(AttributeName = "smoothingLength")]
        public string SmoothingLength { get; set; }
    }

    [XmlRoot(ElementName = "Isochrone")]
    public class Isochrone
    {
        [XmlElement(ElementName = "TileBasedPolygon")]
        public TileBasedPolygon TileBasedPolygon { get; set; }
        [XmlAttribute(AttributeName = "polygonCalculationMode")]
        public string PolygonCalculationMode { get; set; }
        [XmlAttribute(AttributeName = "useLevelling")]
        public string UseLevelling { get; set; }
    }

    [XmlRoot(ElementName = "Bridges")]
    public class Bridges
    {
        [XmlAttribute(AttributeName = "maneuvers")]
        public string Maneuvers { get; set; }
        [XmlAttribute(AttributeName = "maximumDistanceBehind")]
        public string MaximumDistanceBehind { get; set; }
        [XmlAttribute(AttributeName = "minimumLength")]
        public string MinimumLength { get; set; }
    }

    [XmlRoot(ElementName = "Tunnels")]
    public class Tunnels
    {
        [XmlAttribute(AttributeName = "maneuvers")]
        public string Maneuvers { get; set; }
        [XmlAttribute(AttributeName = "maximumDistanceBehind")]
        public string MaximumDistanceBehind { get; set; }
        [XmlAttribute(AttributeName = "minimumLength")]
        public string MinimumLength { get; set; }
    }

    [XmlRoot(ElementName = "Start")]
    public class Start
    {
        [XmlAttribute(AttributeName = "detailLevel")]
        public string DetailLevel { get; set; }
        [XmlAttribute(AttributeName = "radius")]
        public string Radius { get; set; }
    }

    [XmlRoot(ElementName = "Destination")]
    public class Destination
    {
        [XmlAttribute(AttributeName = "detailLevel")]
        public string DetailLevel { get; set; }
        [XmlAttribute(AttributeName = "radius")]
        public string Radius { get; set; }
    }

    [XmlRoot(ElementName = "Urban")]
    public class Urban
    {
        [XmlAttribute(AttributeName = "information")]
        public string Information { get; set; }
        [XmlAttribute(AttributeName = "maneuvers")]
        public string Maneuvers { get; set; }
        [XmlAttribute(AttributeName = "minimumDistanceForManeuvers")]
        public string MinimumDistanceForManeuvers { get; set; }
        [XmlAttribute(AttributeName = "minimumNetworkClassForInformation")]
        public string MinimumNetworkClassForInformation { get; set; }
    }

    [XmlRoot(ElementName = "Maneuvers")]
    public class Maneuvers
    {
        [XmlElement(ElementName = "Bridges")]
        public Bridges Bridges { get; set; }
        [XmlElement(ElementName = "Tunnels")]
        public Tunnels Tunnels { get; set; }
        [XmlElement(ElementName = "Start")]
        public Start Start { get; set; }
        [XmlElement(ElementName = "Destination")]
        public Destination Destination { get; set; }
        [XmlElement(ElementName = "Urban")]
        public Urban Urban { get; set; }
        [XmlAttribute(AttributeName = "detailLevel")]
        public string DetailLevel { get; set; }
        [XmlAttribute(AttributeName = "maneuversAtStartAndDestination")]
        public string ManeuversAtStartAndDestination { get; set; }
    }

    [XmlRoot(ElementName = "ManeuverGroups")]
    public class ManeuverGroups
    {
        [XmlElement(ElementName = "BoundingBox")]
        public BoundingBox BoundingBox { get; set; }
        [XmlAttribute(AttributeName = "maximumDistanceBetweenManeuvers")]
        public string MaximumDistanceBetweenManeuvers { get; set; }
        [XmlAttribute(AttributeName = "maximumNumberOfManeuvers")]
        public string MaximumNumberOfManeuvers { get; set; }
    }

    [XmlRoot(ElementName = "RouteList")]
    public class RouteList
    {
        [XmlElement(ElementName = "Maneuvers")]
        public Maneuvers Maneuvers { get; set; }
        [XmlElement(ElementName = "ManeuverGroups")]
        public ManeuverGroups ManeuverGroups { get; set; }
    }

    [XmlRoot(ElementName = "Polyline")]
    public class Polyline
    {
        [XmlAttribute(AttributeName = "insertExtraPoints")]
        public string InsertExtraPoints { get; set; }
        [XmlAttribute(AttributeName = "maximumDistanceBetweenPolypoints")]
        public string MaximumDistanceBetweenPolypoints { get; set; }
    }

    [XmlRoot(ElementName = "Binary")]
    public class Binary
    {
        [XmlAttribute(AttributeName = "validate")]
        public string Validate { get; set; }
    }

    [XmlRoot(ElementName = "ExceptionPaths")]
    public class ExceptionPaths
    {
        [XmlElement(ElementName = "Polyline")]
        public Polyline Polyline { get; set; }
        [XmlElement(ElementName = "Binary")]
        public Binary Binary { get; set; }
    }

    [XmlRoot(ElementName = "Elevations")]
    public class Elevations
    {
        [XmlAttribute(AttributeName = "maximumNumberOfInterpolationPoints")]
        public string MaximumNumberOfInterpolationPoints { get; set; }
        [XmlAttribute(AttributeName = "minimumSmoothingInclination")]
        public string MinimumSmoothingInclination { get; set; }
        [XmlAttribute(AttributeName = "smoothing")]
        public string Smoothing { get; set; }
        [XmlAttribute(AttributeName = "useBorderTilesForInterpolation")]
        public string UseBorderTilesForInterpolation { get; set; }
    }

    [XmlRoot(ElementName = "AdditionalRules")]
    public class AdditionalRules
    {
        [XmlElement(ElementName = "ExceptionPaths")]
        public ExceptionPaths ExceptionPaths { get; set; }
        [XmlElement(ElementName = "Elevations")]
        public Elevations Elevations { get; set; }
        [XmlAttribute(AttributeName = "maximumAirLineDistance")]
        public string MaximumAirLineDistance { get; set; }
    }

    [XmlRoot(ElementName = "Routing")]
    public class Routing
    {
        [XmlElement(ElementName = "Waypoint")]
        public Waypoint Waypoint { get; set; }
        [XmlElement(ElementName = "Algorithm")]
        public Algorithm Algorithm { get; set; }
        [XmlElement(ElementName = "Course")]
        public Course Course { get; set; }
        [XmlElement(ElementName = "Vehicle")]
        public Vehicle Vehicle { get; set; }
        [XmlElement(ElementName = "Matrix")]
        public Matrix Matrix { get; set; }
        [XmlElement(ElementName = "Isochrone")]
        public Isochrone Isochrone { get; set; }
        [XmlElement(ElementName = "RouteList")]
        public RouteList RouteList { get; set; }
        [XmlElement(ElementName = "AdditionalRules")]
        public AdditionalRules AdditionalRules { get; set; }
        [XmlAttribute(AttributeName = "majorVersion")]
        public string MajorVersion { get; set; }
        [XmlAttribute(AttributeName = "minorVersion")]
        public string MinorVersion { get; set; }
    }

    [XmlRoot(ElementName = "GlobalSettings")]
    public class GlobalSettings
    {
        [XmlAttribute(AttributeName = "enableTimeDependency")]
        public string EnableTimeDependency { get; set; }
        [XmlAttribute(AttributeName = "enableVehicleDependency")]
        public string EnableVehicleDependency { get; set; }
    }

    [XmlRoot(ElementName = "VehicleDependency")]
    public class VehicleDependency
    {
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
    }

    [XmlRoot(ElementName = "FeatureDescription")]
    public class FeatureDescription
    {
        [XmlAttribute(AttributeName = "includeLanguageCode")]
        public string IncludeLanguageCode { get; set; }
        [XmlAttribute(AttributeName = "includeNullValues")]
        public string IncludeNullValues { get; set; }
        [XmlAttribute(AttributeName = "includeTimeDomain")]
        public string IncludeTimeDomain { get; set; }
    }

    [XmlRoot(ElementName = "Theme")]
    public class Theme
    {
        [XmlElement(ElementName = "VehicleDependency")]
        public VehicleDependency VehicleDependency { get; set; }
        [XmlElement(ElementName = "FeatureDescription")]
        public FeatureDescription FeatureDescription { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "priorityLevel")]
        public string PriorityLevel { get; set; }
    }

    [XmlRoot(ElementName = "Themes")]
    public class Themes
    {
        [XmlElement(ElementName = "Theme")]
        public List<Theme> Theme { get; set; }
    }

    [XmlRoot(ElementName = "FeatureLayer")]
    public class FeatureLayer
    {
        [XmlElement(ElementName = "GlobalSettings")]
        public GlobalSettings GlobalSettings { get; set; }
        [XmlElement(ElementName = "Themes")]
        public Themes Themes { get; set; }
        [XmlAttribute(AttributeName = "majorVersion")]
        public string MajorVersion { get; set; }
        [XmlAttribute(AttributeName = "minorVersion")]
        public string MinorVersion { get; set; }
    }

    [XmlRoot(ElementName = "BreakRules")]
    public class BreakRules
    {
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
        [XmlAttribute(AttributeName = "maximumDrivingTimeBeforeBreak")]
        public string MaximumDrivingTimeBeforeBreak { get; set; }
        [XmlAttribute(AttributeName = "minimumDurationOfAdditionalBreaks")]
        public string MinimumDurationOfAdditionalBreaks { get; set; }
        [XmlAttribute(AttributeName = "minimumDurationOfFirstBreak")]
        public string MinimumDurationOfFirstBreak { get; set; }
        [XmlAttribute(AttributeName = "totalBreakPeriod")]
        public string TotalBreakPeriod { get; set; }
    }

    [XmlRoot(ElementName = "RestRules")]
    public class RestRules
    {
        [XmlAttribute(AttributeName = "durationOfShift")]
        public string DurationOfShift { get; set; }
        [XmlAttribute(AttributeName = "enabled")]
        public string Enabled { get; set; }
        [XmlAttribute(AttributeName = "maximumWorkingHoursDuringShift")]
        public string MaximumWorkingHoursDuringShift { get; set; }
        [XmlAttribute(AttributeName = "minimumStayAtStopForRest")]
        public string MinimumStayAtStopForRest { get; set; }
        [XmlAttribute(AttributeName = "restPeriod")]
        public string RestPeriod { get; set; }
    }

    [XmlRoot(ElementName = "BreakAndRestRules")]
    public class BreakAndRestRules
    {
        [XmlElement(ElementName = "BreakRules")]
        public BreakRules BreakRules { get; set; }
        [XmlElement(ElementName = "RestRules")]
        public RestRules RestRules { get; set; }
        [XmlAttribute(AttributeName = "majorVersion")]
        public string MajorVersion { get; set; }
        [XmlAttribute(AttributeName = "minorVersion")]
        public string MinorVersion { get; set; }
    }

    [XmlRoot(ElementName = "Profile")]
    public class Profile
    {
        [XmlElement(ElementName = "Common")]
        public Common Common { get; set; }
        [XmlElement(ElementName = "Routing")]
        public Routing Routing { get; set; }
        [XmlElement(ElementName = "FeatureLayer")]
        public FeatureLayer FeatureLayer { get; set; }
        [XmlElement(ElementName = "BreakAndRestRules")]
        public BreakAndRestRules BreakAndRestRules { get; set; }
        [XmlAttribute(AttributeName = "considerOnlyDrivingAsWorkingHours")]
        public string ConsiderOnlyDrivingAsWorkingHours { get; set; }
        [XmlAttribute(AttributeName = "dataCompatibilityVersion")]
        public string DataCompatibilityVersion { get; set; }
        [XmlAttribute(AttributeName = "majorVersion")]
        public string MajorVersion { get; set; }
        [XmlAttribute(AttributeName = "minorVersion")]
        public string MinorVersion { get; set; }

        private static XmlSerializer serializer = new XmlSerializer(typeof(Profile));
        public string ToSnippet()
        {
            using (var stringWriter = new Utf8StringWriter())
            {
                
                serializer.Serialize(stringWriter, this);
                return stringWriter.ToString();
            }
        }
    }
    internal class Utf8StringWriter : System.IO.StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}




