using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.DAO
{
    public class CandidateProfileDAO
    {
        private static CandidateProfileDAO instance = null;
        private static object instanceLook = new object();

        public static CandidateProfileDAO Instance
        {
            get {
                lock (instanceLook)
                {
                    if (instanceLook.Equals(null))
                    {
                        instanceLook = new CandidateProfileDAO();
                    }
                }
                
                return instance; }
        }

        public List<CandidateProfile> GetCandidateList()
        {
            List<CandidateProfile> candidateList = null;
            try
            {
                PeTestContext context = new PeTestContext();
                candidateList = context.CandidateProfiles.ToList();
            }
            catch(Exception e)
            {

            }
            return candidateList;
    }
}
