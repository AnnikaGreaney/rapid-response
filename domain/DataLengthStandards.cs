namespace RapidResponse.domain
{
    public static class DataLengthStandards
    {
        public const int EntityType = 32;

        public const int StreetAddress = 255;
        public const int City = 64;
        public const int State = 2;
        public const int ZipCode = 10;
        public const int County = 64;

        public const int FirstName = 32;
        public const int MiddleName = 32;
        public const int LastName = 32;

        public const int FullName = FirstName + MiddleName + LastName + 2;


        public const int PostTitle = 256;
        public const int PostContent = 8192;

        public const int TaskDescription = 8192;

        public const int Title = 32;

        public const int LegalName = 255;

        public const int Username = 64;

        public const int Phone = 32;
        public const int AreaCode = 3;
        public const int PhoneBase = 3;
        public const int SubscriberNumber = 4;
        public const int Extension = 18;
        public const int Email = 128;

        public const int TaxID = 11;

        public const int MessageTitle = 128;
        public const int MessageContent = 8192;
        public const int LanguageCode = 5;

        public const int NotificationSubject = 255;

        public const int VerificationMethod = 32;

        public const int DriversLicenseNumber = 32;

        public const int FieldName = 32;

        public const int RoleName = 64;
    }
}
