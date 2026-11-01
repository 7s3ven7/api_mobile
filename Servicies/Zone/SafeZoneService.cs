namespace Services.Zone
{
    public class SafeZoneService
    {
        public static List<Entities.Zone> getZone()
        {
            var zones = new List<Entities.Zone>();
            for (int i = 0; i < 5; i++)
            {
                Entities.Zone zone = new()
                {
                    _type_zone = "safe"
                };
                zone._position._latitude = 48.8566;
                zone._position._longitude = 2.3522;
                zone._level_zone = 1;
                zone._radius = 1000;

                zones.Add(zone);
            }
            return zones;
        }
    }
}
