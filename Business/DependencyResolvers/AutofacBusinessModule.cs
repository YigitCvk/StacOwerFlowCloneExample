using Autofac;
using Business.Abstract;
using Business.Concrete;
using Dal.Abstract;
using Dal.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;

namespace Business.DependencyResolvers
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<QuestionManager>().As<IQuestionService>().SingleInstance();
            builder.RegisterType<EfQuestionDal>().As<IQuestionDal>().SingleInstance();

            builder.RegisterType<AnswerManager>().As<IAnswerService>().SingleInstance();
            builder.RegisterType<EfAnswerDal>().As<IAnswerDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();


        }

    }
}
