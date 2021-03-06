﻿using System.Threading.Tasks;
using Blog.IServices.Base;
using Blog.Model.Models;

namespace Blog.IServices
{
    public partial interface IGuestbookServices : IBaseServices<Guestbook>
    {
        Task<bool> TestTranInRepository();
        Task<bool> TestTranInRepositoryAOP();
    }
}
