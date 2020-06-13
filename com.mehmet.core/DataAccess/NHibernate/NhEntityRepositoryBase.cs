using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using com.mehmet.core.DataAccess.Entity;
using NHibernate;
using NHibernate.Engine;

namespace com.mehmet.core.DataAccess.NHibernate
{
    public class NhEntityRepositoryBase <TEntity>:IEntityRepository <TEntity> 
        where TEntity: class,IEntity,new()
    
    {    // Kullanıcıdan Database Türüne Göre İstenir
        private NhibernateHelper _nhibernateHelper;
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nhibernateHelper.OpenSession())
            {
                //Oturum açıldı
                return filter == null
                    ? session.Query<TEntity>().ToList() // filitre yoksa 
                    : session.Query<TEntity>().Where(filter).ToList();
            }
          
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nhibernateHelper.OpenSession())
            {    
               
                //Oturum açıldı
                // gelen filitreye göre hibernate sorgusu yollanır
                return session.Query<TEntity>().SingleOrDefault(filter);

            }
        }

        public TEntity Add(TEntity entity)
        {
            using (var session = _nhibernateHelper.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {    trans.Begin();
                    session.Save(entity);
                    trans.Commit();
                  
                    return entity;
                }

                
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var session = _nhibernateHelper.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {    trans.Begin();
                    session.Update(entity);
                    trans.Commit();
                 
                    return entity;
                }
            }
        }

        public void Delete(TEntity entity)
        {
            using (var session = _nhibernateHelper.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {    trans.Begin();
                    session.Delete(entity);
                    trans.Commit();
                   
                }
                //Oturum açıldı
               
                
            }
        }

        public List<string> GetSinyalAboneNo()
        {
            using (var session = _nhibernateHelper.OpenSession())
            {


                IList<string> liste = session.CreateSQLQuery("SELECT DISTINCT aboneno FROM \"Sinyaller\"")
                    .AddScalar("aboneno", NHibernateUtil.String).List<string>();

                return liste as List<string>;

            }
        }
        
       
        protected NhEntityRepositoryBase(NhibernateHelper nhibernateHelper)
        {
            _nhibernateHelper = nhibernateHelper;
        }
    }
} 