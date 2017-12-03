using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS.DataModel;

using RS.DataAccessLayer.entitydata;

namespace RS.DataAccessLayer
{
    public class AutosuggestTextDL
    {

        public Dictionary<int, string> GetAllCountry()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();

            using (RSEntities ent = new RSEntities())
            {
                result = ent.RS_Country.Select(t => new { t.CountryId, t.CountryName }).ToDictionary(t => t.CountryId, t => t.CountryName);
            }
            return result;
        }


        public Dictionary<int, string> GetAllStates()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();

            using (RSEntities ent = new RSEntities())
            {
                result = ent.RS_State.Select(t => new { t.StateId, t.StateName }).ToDictionary(t => t.StateId, t => t.StateName);
            }
            return result;
        }


        public Dictionary<int, string> GetAllDistrict()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();

            using (RSEntities ent = new RSEntities())
            {
                result = ent.RS_District.Select(t => new { t.DistrictId, t.DistrictName }).ToDictionary(t => t.DistrictId, t => t.DistrictName);
            }
            return result;
        }


        public Dictionary<int, string> GetAllLocation()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();

            using (RSEntities ent = new RSEntities())
            {
                result = ent.RS_Location.Select(t => new { t.LocationId, t.LocationName }).ToDictionary(t => t.LocationId, t => t.LocationName);
            }
            return result;
        }



        public Dictionary<int, string> GetNewsType()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();

            using (RSEntities ent = new RSEntities())
            {
                result = ent.RS_NewsType.Select(t => new { t.NewsTypeId, t.NewsType }).ToDictionary(t => t.NewsTypeId, t => t.NewsType);
            }
            return result;
        }


        public Dictionary<int, string> GetEventType()
        {
            Dictionary<int, string> result = new Dictionary<int, string>();

            using (RSEntities ent = new RSEntities())
            {
                result = ent.RS_EventType.Select(t => new { t.EventTypeId, t.EventType }).ToDictionary(t => t.EventTypeId, t => t.EventType);
            }
            return result;
        }
    }
}
