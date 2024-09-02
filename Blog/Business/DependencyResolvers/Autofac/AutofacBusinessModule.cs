using Autofac;
using Business.Abstract;
using Business.Concrete;
using Data.Absract;
using Data.Concrete.Mongodb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<MongodbUserDal>().As<IUserDal>();

            builder.RegisterType<CommentManager>().As<ICommentService>();
            builder.RegisterType<MongodbCommentDal>().As<ICommentDal>();

            builder.RegisterType<PostManager>().As<IPostService>();
            builder.RegisterType<MongodbPostDal>().As<IPostDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();

        }
    }
}
