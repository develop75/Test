﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Date : 23-06-2015
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace NHibernateTest.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Mapping table T_GROUP
    /// </summary>
    /// <remarks>
    /// Questa classe genera il proxy per mappare la tabella T_GROUP
    /// </remarks>
    public class Group : Entity
    {
        /// <summary>
        /// Inizializza una nuova istanza
        /// </summary>
        public Group() { }

        /// <summary>
        /// Property CdGroup
        /// </summary>
        public virtual long CdGroup { get; set; }
        /// <summary>
        /// Property CaGroup
        /// </summary>
        public virtual string CaGroup { get; set; }
        /// <summary>
        /// Property FlDelete
        /// </summary>
        public virtual int FlDelete { get; set; }

        /// <summary>
        /// Salvataggio o aggiornamento tabella
        /// </summary>
        public virtual void Save()
        {
            using (var session = NHibernateConfigurator.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(this);

                    transaction.Commit();
                }
            }
        }
        /// <summary>
        /// Load tabella con id specifico
        /// </summary>
        /// <param name="Id">Campo chiave</param>
        /// <returns></returns>
        public static Group GetGroup(long Id,string tagConnection = "DefaulConnection")
        {
            Group group = null;
            using (var session = NHibernateConfigurator.OpenSession(tagConnection))
            {
                group = session.QueryOver<Group>().Where(x => x.CdGroup == Id).SingleOrDefault();
            }

            return group;
        }
    }
}