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

        public List<Stream.DAL.Stream> GetStreamListByType()
        {
            using (StreamEntities db = new StreamEntities())
            {
                return (from stream in db.Streams
                    select stream).ToList();

            }
        } 
    }
}