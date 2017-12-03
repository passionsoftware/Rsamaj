using RS.DataAccessLayer;
using RS.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.BusinessLogicLayer
{
    public class RathoreDetailBL
    {
        RathoreDetailDL _rathoreDetailDL;

        public RathoreDetailBL()
        {
            _rathoreDetailDL = new RathoreDetailDL();
        }

        public int InsertRathoreDetail(RathoreDetailModel objRathoreDetail)
        {
            int result = 0;
            result = _rathoreDetailDL.InsertRathoreDetail(objRathoreDetail);
            return result;
        }

        public int UpdateRathoreDetail(RathoreDetailModel objRathoreDetail)
        {
            int result = 0;
            result = _rathoreDetailDL.UpdateRathoreDetail(objRathoreDetail);
            return result;
        }

        public int DeleteRathoreDetail(int rathoreDetailId)
        {
            int result = 0;
            result = _rathoreDetailDL.DeleteRathoreDetail(rathoreDetailId);
            return result;
        }

        public List<RathoreDetailModel> GetAllRathoreDetail()
        {
            List<RathoreDetailModel> result = new List<RathoreDetailModel>();
            result = _rathoreDetailDL.GetAllRathoreDetail();
            return result;
        }

        public RathoreDetailModel GetRathoreDetailId(int rathoreDetailId)
        {
            RathoreDetailModel result = new RathoreDetailModel();
            result = _rathoreDetailDL.GetRathoreDetailId(rathoreDetailId);
            return result;
        }

        public RathoreDetailDisplayModel GetDetailsToDisplay()
        {
            return _rathoreDetailDL.GetDetailsToDisplay();
        }
    }
}
