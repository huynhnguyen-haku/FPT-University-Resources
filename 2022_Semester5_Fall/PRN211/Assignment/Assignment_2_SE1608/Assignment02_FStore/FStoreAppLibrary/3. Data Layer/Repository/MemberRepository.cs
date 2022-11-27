using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStoreAppLibrary.Data_Layer.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public bool DeleteMember(int memberId) => MemberDao.Instance.Delete(memberId);

        public Member GetMemberById(int memberId) => MemberDao.Instance.GetMemberById(memberId);

        public List<Member> GetMembers() => MemberDao.Instance.GetMembers();

        public bool InsertMember(Member member) => MemberDao.Instance.Insert(member);

        public bool UpdateMember(Member member) => MemberDao.Instance.Update(member);

        public Member CheckExistUser(string email, string password) => MemberDao.Instance.Exist(email, password);  

    }
}
