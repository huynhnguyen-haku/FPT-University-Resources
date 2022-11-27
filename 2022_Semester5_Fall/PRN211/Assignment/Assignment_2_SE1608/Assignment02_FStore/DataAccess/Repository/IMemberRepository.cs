using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FStoreAppLibrary.Data_Layer.Repository
{
    public interface IMemberRepository
    {
        List<Member> GetMembers();
        Member GetMemberById(int memberId);
        Boolean InsertMember(Member member);
        Boolean UpdateMember(Member member);
        Boolean DeleteMember(int memberId);
    }
}
