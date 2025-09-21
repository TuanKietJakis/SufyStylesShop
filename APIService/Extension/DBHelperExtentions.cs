using System.Collections;
using System.Data;
using System.Reflection;

namespace ISUZU_NEXT.Server.Core.Extentions
{
    public static class DBHelperExtentions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static object? GetProperty<T>(this T data,string propertyName)
        {
            var property = data?.GetType()?.GetProperty(propertyName);
            if (property == null)
            {
                return null;
            }

            return property.GetValue(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        public static void SetProperty<T>(this T data, string propertyName, object? value)
        {
            var property = data ?.GetType().GetProperty(propertyName);
            if (property == null)
            {
                return;
            }

            var oldValue = data.GetProperty(propertyName);
            if (object.Equals(value, oldValue))
            {
                return;
            }

            var propertyType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
            try
            {
                var safeValue = (value == null) ? null : Convert.ChangeType(value, propertyType);
                property.SetValue(data, safeValue);
            }
            catch
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="value"></param>
        public static void CopyProperties<TModel, KModel>(this TModel model, KModel value)
        {
            if (model == null || value == null)
            {
                return;
            }

            var destProperties = model.GetType().GetProperties()
                                        .Where(p => p.CanWrite)
                                        .ToDictionary(p => p.Name);

            foreach (var property in value.GetType().GetProperties())
            {
                if (!destProperties.TryGetValue(property.Name, out var destProperty)) continue;

                var sourceValue = property.GetValue(value);
                if (sourceValue == null) continue; // Bỏ qua các giá trị null

                // Kiểm tra kiểu dữ liệu nullable
                var destPropertyType = Nullable.GetUnderlyingType(destProperty.PropertyType) ?? destProperty.PropertyType;
                var sourcePropertyType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

                // Kiểm tra nếu kiểu dữ liệu trùng nhau
                if (sourcePropertyType == destPropertyType)
                {
                    destProperty.SetValue(model, property.GetValue(value));
                }
                else if (IsCollectionType(property.PropertyType) && IsCollectionType(destProperty.PropertyType))
                {
                    CopyCollectionProperty(property, destProperty, value, model);
                }
                else
                {
                    CopyNonCollectionProperty(property, destProperty, value, model);
                }
            }

        }
        /// <summary>
        /// Checks if the type is a collection type (List, ICollection, IEnumerable, etc.)
        /// </summary>
        private static bool IsCollectionType(Type type)
        {
            if (type == null || type == typeof(string))
            {
                return false;
            }

            // Check if the type is an array (array is a collection)
            if (type.IsArray)
            {
                return true; // Arrays are collections
            }

            // Check if the type implements any generic IEnumerable<T>, ICollection<T>, or IList<T> interface
            if (type.GetInterfaces().Any(i => i.IsGenericType &&
                                               (i.GetGenericTypeDefinition() == typeof(IEnumerable<>) ||
                                                i.GetGenericTypeDefinition() == typeof(ICollection<>) ||
                                                i.GetGenericTypeDefinition() == typeof(IList<>))))
            {
                return true; // It's a collection type that implements one of the collection interfaces
            }

            // Check if the type implements the non-generic IEnumerable interface (for collections like ArrayList)
            return typeof(IEnumerable).IsAssignableFrom(type);
        }
        /// <summary>
        /// Copies a collection property from source to destination.
        /// </summary>
        private static void CopyCollectionProperty(PropertyInfo property, PropertyInfo destProperty, object source, object destination)
        {
            var sourceCollection = property.GetValue(source) as IEnumerable;
            if (sourceCollection == null) return;

            var listElementType = destProperty.PropertyType.GetGenericArguments()[0];

            var listType = typeof(List<>).MakeGenericType(listElementType);
            var listCopy = Activator.CreateInstance(listType) as IList;

            foreach (var item in sourceCollection)
            {
                var copyItem = Activator.CreateInstance(listElementType);
                copyItem.CopyProperties(item);
                listCopy?.Add(copyItem);
            }

            destProperty.SetValue(destination, listCopy);
        }

        /// <summary>
        /// Copies a non-collection property from source to destination.
        /// </summary>
        private static void CopyNonCollectionProperty(PropertyInfo property, PropertyInfo destProperty, object source, object destination)
        {
            var sourceValue = property.GetValue(source);
            if (sourceValue == null) return;

            var dtoInstance = Activator.CreateInstance(destProperty.PropertyType);
            dtoInstance.CopyProperties(sourceValue);

            destProperty.SetValue(destination, dtoInstance);
        }
    }
}
