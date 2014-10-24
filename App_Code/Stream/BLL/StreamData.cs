using System.Collections.Generic;
using System.Linq;
using Stream.DAL;
namespace Stream.BLL
{
    /// <summary>
    /// Summary description for StreamData
    /// </summary>
    public class StreamData
    {
        public StreamData()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public List<Stream.DAL.Stream> GetStreamList()
        {
            using (StreamEntities db = new StreamEntities())
            {
                return (from stream in db.Streams
                    select stream).ToList();

            }
        }

        public void StreamViewsCounter(int streamID)
        {
            using (StreamEntities db = new StreamEntities())
            {
                StreamView selectStreamView = (from s in db.StreamViews
                    where s.streamID == streamID
                    select s).SingleOrDefault();

                if (selectStreamView == null)  //if not exists add
                {
                    StreamView streamView = new StreamView
                    {
                        streamID = streamID,
                        intNumberOfViews = 1
                    };
                    db.StreamViews.Add(streamView);
                    db.SaveChanges();


                }
                else // update
                {
                    selectStreamView.intNumberOfViews = selectStreamView.intNumberOfViews + 1;
                    db.SaveChanges();

                }

            }
        }
    }
}