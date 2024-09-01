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
            builder.RegisterType<IUserService>().As<UserManager>();
            builder.RegisterType<IUserDal>().As<MongodbUserDal>();
        }
    }
}
