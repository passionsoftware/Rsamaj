using RS.DataAccessLayer;
using RS.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.BusinessLogicLayer
{
    public class EventBL
    {
        EventDL _eventDL;

        public EventBL()
        {
            _eventDL = new EventDL();
        }

        public int InsertEvent(EventModel obj)
        {
            int result = 0;
            result = _eventDL.InsertEvent(obj);
            return result;
        }

        public int UpdateEvent(EventModel obj)
        {
            int result = 0;
            result = _eventDL.UpdateEvent(obj);
            return result;
        }

        public int DeleteEvent(int id)
        {
            int result = 0;
            result = _eventDL.DeleteEvent(id);
            return result;
        }

        public List<EventModel> GetAllEvent()
        {
            List<EventModel> result = new List<EventModel>();
            result = _eventDL.GetAllEvent();
            return result;
        }

        public EventModel GetEventId(int id)
        {
            EventModel result = new EventModel();
            result = _eventDL.GetEventId(id);
            return result;
        }
    }
}
