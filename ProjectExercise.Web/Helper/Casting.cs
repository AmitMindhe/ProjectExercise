using AutoMapper;
using ProjectExercise.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace ProjectExercise.Web
{
    public static partial class Casting
    {
        public static TDestination ToViewModel<TSource, TDestination>(this TSource source)
        {
            if (source == null)
                return default(TDestination);

            var viewModel = (TDestination)Mapper.Map(source, source.GetType(), typeof(TDestination));

            MethodInfo method = viewModel.GetType().GetMethod("UpdateNames");
            if (method != null)
                method.Invoke(viewModel, null);

            return viewModel;
        }

        public static TDestination ToCoreEntity<TSource, TDestination>(this TSource source)
        {
            if (source == null)
                return default(TDestination);

            //set values of created by, modified by etc to current values
            var baseEntity = source as BaseEntityViewModel;
            if (baseEntity != null)
            {
                if (!baseEntity.Created.HasValue || baseEntity.Created.Value == default(DateTime))
                    baseEntity.Created = DateTime.UtcNow;

                baseEntity.Modified = DateTime.UtcNow;

            //    var currentUser = System.Web.HttpContext.Current.User as CustomPrincipal;

                //this should be int value
               // baseEntity.ModifiedBy = currentUser == null ? 1 : currentUser.UserId;
               // baseEntity.CreatedBy = currentUser == null ? 1 : currentUser.UserId;
            }

            var viewModel = (TDestination)Mapper.Map(source, source.GetType(), typeof(TDestination));
            return viewModel;
        }

        public static PaginationList<TDestination> ToPaginationListViewModel<TSource, TDestination>(this IPagedList<TSource> source, string searchText = "")
        {
            if (source == null)
                return new PaginationList<TDestination>();

            return new PaginationList<TDestination>()
            {
                Items = source.ToList().ToViewModel<List<TSource>, List<TDestination>>(),
                PageSize = source.PageSize,
                PageNumber = source.PageNumber,
                TotalItemCount = source.TotalItemCount,
                SearchText = searchText
            };
        }

        public static void UpdateListItem<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }
    }
}