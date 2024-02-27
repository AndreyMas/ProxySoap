using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // 1. Создать WCF проект.
    // 2. Сгенерировать cs по wsdl с помощью wsdl.exe (например через SOAPUI).
    // 3. Разметить сформированный cs аттрибутами [ServiceContract] [OperationContract] [DataContract] [DataMember].
    // 4. Реализовать класс от интерфейса сервиса.
    // 5. Реализовать фиктивные методы.
    public class Service1 : ISI_GetADUser_OutBinding
    {
        public DT_UserResponseRow[] SI_GetADUser_Out([System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:alrosa:AD:Users")] DT_UserFilter MT_UserFilter)
        {
            var userFilter = MT_UserFilter.PersonalNumber;

            var userResponseRows = new List<DT_UserResponseRow>();

            var user1 = new DT_UserResponseRow();
            user1.DomainName = "directum";
            user1.LoginName = "aaa";
            user1.FirstName = "vvv";
            user1.PersonalNumber = userFilter;
            userResponseRows.Add(user1);

            return userResponseRows.ToArray();
        }
    }
}
