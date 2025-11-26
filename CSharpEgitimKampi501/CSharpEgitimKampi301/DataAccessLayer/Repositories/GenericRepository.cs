using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    //entity state crud işlemlerinde fayda sağlıyor, 
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        CampContext context = new CampContext();
        private readonly DbSet<T> _object;
        public GenericRepository() {
            _object = context.Set<T>(); //  
        }
        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            //listeyi direk getirsin.
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        //Bu tipik bir Generic Repository Insert metodudur.
        //Yani T hangi entity ise (Customer, Guide, Location…),
        //onu veritabanına eklemeyi standart hale getiriyor.
        public void Insert(T entity)
        {
            //EF’nin DbContexti bir takipçi (Change Tracker) gibi çalışır.
            //Sen bir entity verdiğinde EF şunu sorar:
            //“Bu nesneyle ne yapacağım? Takip edeyim mi? Durumu ne ?” YANİ NE YAPACAM BUNUNLA DİYOR 
            //BEN DE DİYORUM Kİ 
            //context.Entry(entity) diyerek:
            // o entity’yi context’in takip sistemine sok
            // sana onun Entry(takip kaydı) nesnesini veriyor.
            var addedEntity = context.Entry(entity);
            //addedEntity 'de takip nesnesini aldım. = “EF'cim, şu entity’yi tanı ve izle. Bana da onun takip kartını ver.”
         /**
          * Burada EF’ye net emir veriyorsun:
           “Bu entity yeni, bunu veritabanına INSERT edeceksin.”
            Entity’nin durumu Added olunca EF şunu bilir:
            SaveChanges geldiğinde buna INSERT atacak.
            Yani arka planda “eklenecekler listesine” koymuş oluyorsun.*/ 
            addedEntity.State = EntityState.Added;
            /**
             * ve aşağıda da 
             * Bu da tetiği çektiğin yer
             * .EF o ana kadar sadece plan yapıyordu.
             * SaveChanges() deyince:
             * Change Tracker’a bakar,
             * State’i Added olanları bulur,
             * SQL üretir,
             * DB’ye gönderir.
             **/
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
