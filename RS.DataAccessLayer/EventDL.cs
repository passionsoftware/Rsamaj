using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RS.DataModel;
using RS.DataAccessLayer.entitydata;


namespace RS.DataAccessLayer
{
    public class EventDL
    {

        public int InsertEvent(EventModel obj)
        {
            int result = 0;

            using (RSEntities objEnt = new RSEntities())
            {

                RS_Event oData = new RS_Event();
                oData.EventType = obj.EventType;
                oData.Subject = obj.Subject;
                oData.Body = obj.Body;
                oData.EventDateFrom = obj.EventDateFrom;
                oData.EventTimeFrom = obj.EventTimeFrom;
                oData.EventDateTo = obj.EventDateTo;
                oData.EventTimeTo = obj.EventTimeTo;
                oData.Location = obj.Location;
                oData.District = obj.District;
                oData.CreatedBy = obj.CreatedBy;
                oData.CreatedOn = DateTime.Now;
                oData.IsActive = true;

                //oData.CreatedOn = ;
                //oData.Location = obj.Location;
                //oData.IpAddress = obj.IpAddress;

                objEnt.RS_Event.Add(oData);

                result = objEnt.SaveChanges();
            }

            return result;
        }

        public int UpdateEvent(EventModel obj)
        {
            int result = 0;

            using (RSEntities objEnt = new RSEntities())
            {
                var oData = objEnt.RS_Event.Where(i => i.EventId == obj.EventId).First();
                oData.EventType = obj.EventType;
                oData.Subject = obj.Subject;
                oData.Body = obj.Body;
                oData.EventDateFrom = obj.EventDateFrom;
                oData.EventTimeFrom = obj.EventTimeFrom;
                oData.EventDateTo = obj.EventDateTo;
                oData.EventTimeTo = obj.EventTimeTo;
                oData.Location = obj.Location;
                oData.District = obj.District;
                oData.ModifiedBy = obj.ModifiedBy;
                oData.ModifiedOn = DateTime.Now;
                oData.IsActive = true;

                result = objEnt.SaveChanges();
            }

            return result;
        }

        public int DeleteEvent(int Id)
        {
            int result = 0;

            using (RSEntities obj = new RSEntities())
            {
                var oSelect = obj.RS_Event.First(i => i.EventId == Id);
                obj.RS_Event.Remove(oSelect);

                result = obj.SaveChanges();
            }

            return result;
        }

        public List<EventModel> GetAllEvent()
        {
            List<EventModel> result = new List<EventModel>();
            using (RSEntities ent = new RSEntities())
            {

                result = (from obj in ent.RS_Event
                          from ET in ent.RS_EventType.Where(ET => ET.EventTypeId  == obj.EventType).DefaultIfEmpty() // <== makes join left join
                          from CDs in ent.RS_District.Where(CD => CD.DistrictId == obj.District).DefaultIfEmpty() // <== makes join left join
                          from CLs in ent.RS_Location.Where(CL => CL.LocationId == obj.Location).DefaultIfEmpty() // <== makes join left join
                          from RD in ent.RS_RathoreDetails.Where(CL => CL.RathoreDetailId == obj.CreatedBy).DefaultIfEmpty() // <== makes join left join

                          select new EventModel
                          {
                              Subject = obj.Subject,
                              Body   = obj.Body,
                              EventDateFrom = obj.EventDateFrom,
                              EventTimeFrom = obj.EventTimeFrom,
                              EventDateTo = obj.EventDateTo,
                              EventTimeTo = obj.EventTimeTo,
                              Location = obj.Location,
                              LocationName = CLs.LocationName,

                              District = obj.District,
                              DistrictName = CDs.DistrictName,
                              CreatedOn = obj.CreatedOn,
                              CreatedBy = obj.CreatedBy,
                              CreaterName = RD.Name,

                              ModifiedBy = obj.ModifiedBy,
                          }).ToList();
            }

            return result;
        }

        public EventModel GetEventId(int Id)
        {
            EventModel result = new EventModel();
            using (RSEntities ent = new RSEntities())
            {

                result = (from obj in ent.RS_Event
                          from ET in ent.RS_EventType.Where(ET => ET.EventTypeId == obj.EventType).DefaultIfEmpty() // <== makes join left join
                          from CDs in ent.RS_District.Where(CD => CD.DistrictId == obj.District).DefaultIfEmpty() // <== makes join left join
                          from CLs in ent.RS_Location.Where(CL => CL.LocationId == obj.Location).DefaultIfEmpty() // <== makes join left join
                          from RD in ent.RS_RathoreDetails.Where(CL => CL.RathoreDetailId == obj.CreatedBy).DefaultIfEmpty() // <== makes join left join
                          where obj.EventId == Id
                          select new EventModel
                          {
                              Subject = obj.Subject,
                              Body = obj.Body,
                              EventDateFrom = obj.EventDateFrom,
                              EventTimeFrom = obj.EventTimeFrom,
                              EventDateTo = obj.EventDateTo,
                              EventTimeTo = obj.EventTimeTo,
                              Location = obj.Location,
                              LocationName = CLs.LocationName,

                              District = obj.District,
                              DistrictName = CDs.DistrictName,
                              CreatedOn = obj.CreatedOn,
                              CreatedBy = obj.CreatedBy,
                              CreaterName = RD.Name,

                              ModifiedBy = obj.ModifiedBy,
                          }).ToList().FirstOrDefault();
            }

            return result;
        }
    }
}
