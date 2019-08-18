using ROM.Models.Models;
using ROM.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ROM.BLL.BLL
{
    
    public class MemberManager
    {
        MemberRepository memberRepository = new MemberRepository();
        public bool Add(Member member)
        {


            return memberRepository.Add(member);
        }
    }
}
