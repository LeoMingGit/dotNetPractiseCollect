using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreTest.关系配置.一对多.VO;
using AutoMapper;

namespace EfCoreTest.关系配置.一对多
{
    public static class TestData
    {
        public static void Test()
        {
            // InsertData();
            RelateQuery();
        }


        /// <summary>
        /// ef  关联查询
        /// </summary>
        private static void RelateQuery()
        {
            //关联查询

            using TestDbContext ctx = new TestDbContext();
            List<ArticleCommentItemResult> lst = ctx.Articles.Include(a => a.Comments).Select(
                        p =>
                            new ArticleCommentItemResult
                            {
                                ArticleTitle = p.Title,
                                CmtMsgLst = p.Comments.Select(x => x.Message).ToList()
                            }
                ).ToList();
        }

        private static void InsertData()
        {
            //插入数据

            Article a1 = new Article();
            a1.Code = Guid.NewGuid().ToString("N");
            a1.Title = "微软发布.NET 6大版本的首个预览";
            a1.Content = "微软昨日在一篇官网博客文章中宣布了 .NET 6 首个预览版本的到来。";
            Comment c1 = new Comment() { Code = Guid.NewGuid().ToString("N"), Message = "支持" };
            Comment c2 = new Comment() { Code = Guid.NewGuid().ToString("N"), Message = "微软太牛了" };
            Comment c3 = new Comment() { Code = Guid.NewGuid().ToString("N"), Message = "火钳刘明" };
            a1.Comments.Add(c1);
            a1.Comments.Add(c2);
            a1.Comments.Add(c3);
            using TestDbContext ctx = new TestDbContext();
            ctx.Articles.Add(a1);
            ctx.SaveChanges();

        }
    }
}
