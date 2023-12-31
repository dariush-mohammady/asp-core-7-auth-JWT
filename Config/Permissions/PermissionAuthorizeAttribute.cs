﻿using Microsoft.AspNetCore.Authorization;

namespace AuthJWT.Config.Permissions
{
    public class PermissionAuthorizeAttribute : AuthorizeAttribute
    {
        internal const string PolicyPrefix = "PERMISSION:";

        public PermissionAuthorizeAttribute(params string[] permissions)
        {
            Policy = $"{PolicyPrefix}{string.Join(",", permissions)}";
        }
    }
}
