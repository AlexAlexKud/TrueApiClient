﻿namespace FairMark.TrueApi.DataContracts._3_1
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Результат обработки заявки на регистрацию.
    /// 3.1.2. Метод проверки статуса заявки УОТ на регистрацию по ID заявки
    /// </summary>
    [DataContract]
    public class RegistrationStatusResponse
    {
        [DataMember(Name = "registrationRequestStatus")]
        public string RegistrationRequestStatus { get; set; }

        [DataMember(Name = "documentType")]
        public string DocumentType { get; set; }

        [DataMember(Name = "errors")]
        public RegistrationStatusError[] Errors { get; set; }
    }
}
