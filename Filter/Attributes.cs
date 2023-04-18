using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDirectorySearcher
{
    public class Attributes
    {
        public const string SamAccountName = "SamAccountName";
        public const string AdsPath = "adspath";
        public const string ObjectGuid = "objectGUID";
        public const string ObjectSid = "objectSid";
        public const string ObjectClass = "ObjectClass";
        public const string ArrayObjectClass = "array-ObjectClass";
        public const string ObjectCategory = "objectCategory";
        public const string DistinguishedName = "distinguishedName";
        public const string ManagedBy = "managedby";
        public const string MemberOf = "memberOf";
        public const string Member = "member";
        public const string MemberRange = "member;range=";
        public const string MsDsLastKnownRDN = "msDS-LastKnownRDN";
        public const string LastKnownParent = "LastKnownParent";
        public const string PwdLastSet = "pwdLastSet";
        public const string UserAccountControl = "userAccountcontrol";
        public const string LastLogonTimestamp = "lastLogonTimestamp";
        public const string CreateTimeStamp = "createTimeStamp";
        public const string MsDsResultantPso = "msDS-ResultantPSO";
        public const string PrimaryGroupId = "primaryGroupId";
        public const string PrimaryGroupName = "primaryGroupName";
        public const string ProxyAddresses = "proxyAddresses";
        public const string AccountExpires = "accountExpires";
        public const string GroupType = "groupType";
        public const string Description = "Description";
        public const string DisplayName = "DisplayName";
        public const string Name = "Name";
        public const string Mail = "Mail";
        public const string MailNickName = "MailNickName";
        public const string MsExchHideFromAddressLists = "msExchHideFromAddressLists";
        public const string UserPrincipalName = "userPrincipalName";
        public const string WhenChanged = "whenChanged";

        public const string ExtensionAttribute1 = "extensionAttribute1";
        public const string ExtensionAttribute2 = "extensionAttribute2";
        public const string ExtensionAttribute4 = "extensionAttribute4";
        public const string ExtensionAttribute5 = "extensionAttribute5";
        public const string ExtensionAttribute10 = "extensionAttribute10";
        public const string ExtensionAttribute11 = "extensionAttribute11"; // for alts and sc-alts

        public const string GMSAGroupPrefix = "ALLOW_TO_USE_";
        public const string GMSAGroupMSAMembership = "msDS-GroupMSAMembership";
        public const string GMSAManagedPasswordInterval = "msDS-ManagedPasswordInterval";
        public const string GMSASupportedEncryptionTypes = "msDS-SupportedEncryptionTypes";

        public const string ObjectSubTypeId = "ObjectSubTypeId";

        public const string IsDeleted = "isDeleted";
    }
}
