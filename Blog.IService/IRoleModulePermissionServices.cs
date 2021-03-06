﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Blog.IServices.Base;
using Blog.Model.Models;

namespace Blog.IServices
{
    public interface IRoleModulePermissionServices : IBaseServices<RoleModulePermission>
    {

        Task<List<RoleModulePermission>> GetRoleModule();
        Task<List<RoleModulePermission>> TestModelWithChildren();

        //Task<List<TestMuchTableResult>> QueryMuchTable();
        Task<List<RoleModulePermission>> RoleModuleMaps();
    }
}
