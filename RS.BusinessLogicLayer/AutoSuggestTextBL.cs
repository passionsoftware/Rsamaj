using RS.DataAccessLayer;
using RS.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.BusinessLogicLayer
{
    public class AutoSuggestTextBL
    {
        AutosuggestTextDL _autosuggestTextDL;

        public AutoSuggestTextBL()
        {
            _autosuggestTextDL = new AutosuggestTextDL();
        }

        public Dictionary<int, string> GetAllCountry()
        {
            return _autosuggestTextDL.GetAllCountry();
        }


        public Dictionary<int, string> GetAllStates()
        {
            return _autosuggestTextDL.GetAllStates();
        }

        public Dictionary<int, string> GetStatesByCountry()
        {
            return _autosuggestTextDL.GetAllStates();
        }


        public Dictionary<int, string> GetAllDistrict()
        {
            return _autosuggestTextDL.GetAllDistrict();
        }


        public Dictionary<int, string> GetAllLocation()
        {
            return _autosuggestTextDL.GetAllLocation();
        }



        public Dictionary<int, string> GetNewsType()
        {
            return _autosuggestTextDL.GetNewsType();
        }


        public Dictionary<int, string> GetEventType()
        {
            return _autosuggestTextDL.GetEventType();
        }

    }
}
