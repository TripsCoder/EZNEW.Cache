using EZNEW.Cache.Command;
using EZNEW.Cache.Command.Result;
using EZNEW.Cache.Response;
using EZNEW.Framework.Extension;
using EZNEW.Framework.Serialize;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    /// <summary>
    /// cache manager
    /// </summary>
    public static class CacheManager
    {
        #region operation

        #region string

        #region StringSetRange

        /// <summary>
        /// Overwrites part of the string stored at key, starting at the specified offset,
        /// for the entire length of value. If the offset is larger than the current length
        /// of the string at key, the string is padded with zero-bytes to make offset fit.
        /// Non-existing keys are considered as empty strings, so this command will make
        /// sure it holds a string large enough to be able to set value at offset.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string set range response</returns>
        public static async Task<CacheCommandResult<StringSetRangeResponse>> StringSetRangeAsync(StringSetRangeCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringSetBit

        /// <summary>
        /// Sets or clears the bit at offset in the string value stored at key. The bit is
        /// either set or cleared depending on value, which can be either 0 or 1. When key
        /// does not exist, a new string value is created.The string is grown to make sure
        /// it can hold a bit at offset.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string set bit response</returns>
        public static async Task<CacheCommandResult<StringSetBitResponse>> StringSetBitAsync(StringSetBitCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringSet

        /// <summary>
        /// Set key to hold the string value. If key already holds a value, it is overwritten,
        /// regardless of its type.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string set response</returns>
        public static async Task<CacheCommandResult<StringSetResponse>> StringSetAsync(StringSetCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringLength

        /// <summary>
        /// Returns the length of the string value stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string length response</returns>
        public static async Task<CacheCommandResult<StringLengthResponse>> StringLengthAsync(StringLengthCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringIncrement

        /// <summary>
        /// Increments the string representing a floating point number stored at key by the
        /// specified increment. If the key does not exist, it is set to 0 before performing
        /// the operation. The precision of the output is fixed at 17 digits after the decimal
        /// point regardless of the actual internal precision of the computation.
        /// </summary>
        /// <typeparam name="T">data type</typeparam>
        /// <param name="command">command</param>
        /// <returns>string increment response</returns>
        public static async Task<CacheCommandResult<Response.StringIncrementResponse<T>>> StringIncrementAsync<T>(Command.StringIncrementCommand<T> command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringGetWithExpiry

        /// <summary>
        /// Get the value of key. If the key does not exist the special value nil is returned.
        /// An error is returned if the value stored at key is not a string, because GET
        /// only handles string values.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string get with expiry response</returns>
        public static async Task<CacheCommandResult<StringGetWithExpiryResponse>> StringGetWithExpiryAsync(StringGetWithExpiryCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringGetSet

        /// <summary>
        /// Atomically sets key to value and returns the old value stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string get set response</returns>
        public static async Task<CacheCommandResult<StringGetSetResponse>> StringGetSetAsync(StringGetSetCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringGetRange

        /// <summary>
        /// Returns the substring of the string value stored at key, determined by the offsets
        /// start and end (both are inclusive). Negative offsets can be used in order to
        /// provide an offset starting from the end of the string. So -1 means the last character,
        /// -2 the penultimate and so forth.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string get range response</returns>
        public static async Task<CacheCommandResult<StringGetRangeResponse>> StringGetRangeAsync(StringGetRangeCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringGetBit

        /// <summary>
        /// Returns the bit value at offset in the string value stored at key. When offset
        /// is beyond the string length, the string is assumed to be a contiguous space with
        /// 0 bits
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string get bit response</returns>
        public static async Task<CacheCommandResult<StringGetBitResponse>> StringGetBitAsync(StringGetBitCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringGet

        /// <summary>
        /// Returns the values of all specified keys. For every key that does not hold a
        /// string value or does not exist, the special value nil is returned.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string get response</returns>
        public static async Task<CacheCommandResult<StringGetResponse>> StringGetAsync(StringGetCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        /// <summary>
        /// get value
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="cacheObject">cache object</param>
        /// <returns></returns>
        public static async Task<string> StringGetAsync(string key, CacheObject cacheObject = null)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return string.Empty;
            }
            var values = await StringGetAsync(new List<string>() { key }, cacheObject).ConfigureAwait(false);
            return values?.FirstOrDefault() ?? string.Empty;
        }

        /// <summary>
        /// return value
        /// </summary>
        /// <param name="key">cache key</param>
        /// <param name="cacheObject">cache object</param>
        /// <returns></returns>
        public static async Task<T> StringGetAsync<T>(string key, CacheObject cacheObject = null)
        {
            var cacheValue = await StringGetAsync(key, cacheObject).ConfigureAwait(false);
            if (cacheValue.IsNullOrEmpty())
            {
                return default(T);
            }
            try
            {
                return JsonSerialize.JsonToObject<T>(cacheValue);
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }

        /// <summary>
        /// return values
        /// </summary>
        /// <param name="keys">keys</param>
        /// <param name="cacheObject">cache object</param>
        /// <returns></returns>
        public static async Task<List<string>> StringGetAsync(IEnumerable<string> keys, CacheObject cacheObject = null)
        {
            if (keys.IsNullOrEmpty())
            {
                return new List<string>(0);
            }
            var result = await StringGetAsync(new StringGetCommand()
            {
                CacheObject = cacheObject,
                Keys = keys.ToList()
            }).ConfigureAwait(false);
            List<string> values = new List<string>();
            if (result?.Responses?.Count > 0)
            {
                foreach (var response in result.Responses)
                {
                    if (response.Values.IsNullOrEmpty())
                    {
                        continue;
                    }
                    values = values.Union(response.Values.Select(c => c.Value?.ToString() ?? string.Empty)).ToList();
                }
            }
            return values;
        }

        /// <summary>
        /// return values
        /// </summary>
        /// <typeparam name="T">data type</typeparam>
        /// <param name="keys">keys</param>
        /// <param name="cacheObject">cache object</param>
        /// <returns></returns>
        public static async Task<List<T>> StringGetAsync<T>(IEnumerable<string> keys, CacheObject cacheObject = null)
        {
            var values = await StringGetAsync(keys, cacheObject).ConfigureAwait(false);
            if (values.IsNullOrEmpty())
            {
                return new List<T>(0);
            }
            var datas = new List<T>(values.Count);
            foreach (var val in values)
            {
                try
                {
                    var data = JsonSerialize.JsonToObject<T>(val);
                    if (data == null)
                    {
                        continue;
                    }
                    datas.Add(data);
                }
                catch (Exception ex)
                {
                }
            }
            return datas;
        }

        #endregion

        #region StringDecrement

        /// <summary>
        /// Decrements the number stored at key by decrement. If the key does not exist,
        /// it is set to 0 before performing the operation. An error is returned if the key
        /// contains a value of the wrong type or contains a string that is not representable
        /// as integer. This operation is limited to 64 bit signed integers.
        /// </summary>
        /// <typeparam name="T">data type</typeparam>
        /// <param name="command">command</param>
        /// <returns>string decrement response</returns>
        public static async Task<CacheCommandResult<StringDecrementResponse<T>>> StringDecrementAsync<T>(StringDecrementCommand<T> command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringBitPosition

        /// <summary>
        /// Return the position of the first bit set to 1 or 0 in a string. The position
        /// is returned thinking at the string as an array of bits from left to right where
        /// the first byte most significant bit is at position 0, the second byte most significant
        /// bit is at position 8 and so forth. An start and end may be specified; these are
        /// in bytes, not bits; start and end can contain negative values in order to index
        /// bytes starting from the end of the string, where -1 is the last byte, -2 is the
        /// penultimate, and so forth.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string bit position response</returns>
        public static async Task<CacheCommandResult<StringBitPositionResponse>> StringBitPositionAsync(StringBitPositionCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringBitOperation

        /// <summary>
        /// Perform a bitwise operation between multiple keys (containing string values)
        ///  and store the result in the destination key. The BITOP command supports four
        ///  bitwise operations; note that NOT is a unary operator: the second key should
        ///  be omitted in this case and only the first key will be considered. The result
        /// of the operation is always stored at destkey.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string bit operation response</returns>
        public static async Task<CacheCommandResult<StringBitOperationResponse>> StringBitOperationAsync(StringBitOperationCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringBitCount

        /// <summary>
        /// Count the number of set bits (population counting) in a string. By default all
        /// the bytes contained in the string are examined.It is possible to specify the
        /// counting operation only in an interval passing the additional arguments start
        /// and end. Like for the GETRANGE command start and end can contain negative values
        /// in order to index bytes starting from the end of the string, where -1 is the
        /// last byte, -2 is the penultimate, and so forth.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string bit count response</returns>
        public static async Task<CacheCommandResult<StringBitCountResponse>> StringBitCountAsync(StringBitCountCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region StringAppend

        /// <summary>
        /// If key already exists and is a string, this command appends the value at the
        /// end of the string. If key does not exist it is created and set as an empty string,
        /// so APPEND will be similar to SET in this special case.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>string append response</returns>
        public static async Task<CacheCommandResult<StringAppendResponse>> StringAppendAsync(StringAppendCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region list

        #region ListTrim

        /// <summary>
        /// Trim an existing list so that it will contain only the specified range of elements
        /// specified. Both start and stop are zero-based indexes, where 0 is the first element
        /// of the list (the head), 1 the next element and so on. For example: LTRIM foobar
        /// 0 2 will modify the list stored at foobar so that only the first three elements
        /// of the list will remain. start and end can also be negative numbers indicating
        /// offsets from the end of the list, where -1 is the last element of the list, -2
        /// the penultimate element and so on.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list trim response</returns>
        public static async Task<CacheCommandResult<ListTrimResponse>> ListTrimAsync(ListTrimCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListSetByIndex

        /// <summary>
        /// Sets the list element at index to value. For more information on the index argument,
        ///  see ListGetByIndex. An error is returned for out of range indexes.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list set by index response</returns>
        public static async Task<CacheCommandResult<ListSetByIndexResponse>> ListSetByIndexAsync(ListSetByIndexCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListRightPush

        /// <summary>
        /// Insert all the specified values at the tail of the list stored at key. If key
        /// does not exist, it is created as empty list before performing the push operation.
        /// Elements are inserted one after the other to the tail of the list, from the leftmost
        /// element to the rightmost element. So for instance the command RPUSH mylist a
        /// b c will result into a list containing a as first element, b as second element
        /// and c as third element.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list right push</returns>
        public static async Task<CacheCommandResult<ListRightPushResponse>> ListRightPushAsync(ListRightPushCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListRightPopLeftPush

        /// <summary>
        /// Atomically returns and removes the last element (tail) of the list stored at
        /// source, and pushes the element at the first element (head) of the list stored
        /// at destination.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list right pop left response</returns>
        public static async Task<CacheCommandResult<ListRightPopLeftPushResponse>> ListRightPopLeftPushAsync(ListRightPopLeftPushCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListRightPop

        /// <summary>
        /// Removes and returns the last element of the list stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list right pop response</returns>
        public static async Task<CacheCommandResult<ListRightPopResponse>> ListRightPopAsync(ListRightPopCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListRemove

        /// <summary>
        /// Removes the first count occurrences of elements equal to value from the list
        /// stored at key. The count argument influences the operation in the following way
        /// count > 0: Remove elements equal to value moving from head to tail. count less 0:
        /// Remove elements equal to value moving from tail to head. count = 0: Remove all
        /// elements equal to value.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list remove response</returns>
        public static async Task<CacheCommandResult<ListRemoveResponse>> ListRemoveAsync(ListRemoveCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListRange

        /// <summary>
        /// Returns the specified elements of the list stored at key. The offsets start and
        /// stop are zero-based indexes, with 0 being the first element of the list (the
        /// head of the list), 1 being the next element and so on. These offsets can also
        /// be negative numbers indicating offsets starting at the end of the list.For example,
        /// -1 is the last element of the list, -2 the penultimate, and so on. Note that
        /// if you have a list of numbers from 0 to 100, LRANGE list 0 10 will return 11
        /// elements, that is, the rightmost item is included.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list range response</returns>
        public static async Task<CacheCommandResult<ListRangeResponse>> ListRangeAsync(ListRangeCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListLength

        /// <summary>
        /// Returns the length of the list stored at key. If key does not exist, it is interpreted
        ///  as an empty list and 0 is returned.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list length response</returns>
        public static async Task<CacheCommandResult<ListLengthResponse>> ListLengthAsync(ListLengthCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListLeftPush

        /// <summary>
        /// Insert the specified value at the head of the list stored at key. If key does
        ///  not exist, it is created as empty list before performing the push operations.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list left push response</returns>
        public static async Task<CacheCommandResult<ListLeftPushResponse>> ListLeftPushAsync(ListLeftPushCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListLeftPop

        /// <summary>
        /// Removes and returns the first element of the list stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list left pop response</returns>
        public static async Task<CacheCommandResult<ListLeftPopResponse>> ListLeftPopAsync(ListLeftPopCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListInsertBefore

        /// <summary>
        /// Inserts value in the list stored at key either before or after the reference
        /// value pivot. When key does not exist, it is considered an empty list and no operation
        /// is performed.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list insert begore response</returns>
        public static async Task<CacheCommandResult<ListInsertBeforeResponse>> ListInsertBeforeAsync(ListInsertBeforeCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListInsertAfter

        /// <summary>
        /// Inserts value in the list stored at key either before or after the reference
        /// value pivot. When key does not exist, it is considered an empty list and no operation
        /// is performed.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list insert after response</returns>
        public static async Task<CacheCommandResult<ListInsertAfterResponse>> ListInsertAfterAsync(ListInsertAfterCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region ListGetByIndex

        /// <summary>
        /// Returns the element at index index in the list stored at key. The index is zero-based,
        /// so 0 means the first element, 1 the second element and so on. Negative indices
        /// can be used to designate elements starting at the tail of the list. Here, -1
        /// means the last element, -2 means the penultimate and so forth.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>list get by index response</returns>
        public static async Task<CacheCommandResult<ListGetByIndexResponse>> ListGetByIndexAsync(ListGetByIndexCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region Hash

        #region HashValues

        /// <summary>
        /// Returns all values in the hash stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>hash values response</returns>
        public static async Task<CacheCommandResult<HashValuesResponse>> HashValuesAsync(HashValuesCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region HashSet

        /// <summary>
        /// Sets field in the hash stored at key to value. If key does not exist, a new key
        ///  holding a hash is created. If field already exists in the hash, it is overwritten.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>hash set response</returns>
        public static async Task<CacheCommandResult<HashSetResponse>> HashSetAsync(HashSetCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region HashLength

        /// <summary>
        /// Returns the number of fields contained in the hash stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>hash length response</returns>
        public static async Task<CacheCommandResult<HashLengthResponse>> HashLengthAsync(HashLengthCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region HashKeys

        /// <summary>
        /// Returns all field names in the hash stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>hash keys response</returns>
        public static async Task<CacheCommandResult<HashKeysResponse>> HashKeysAsync(HashKeysCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region HashIncrement

        /// <summary>
        /// Increments the number stored at field in the hash stored at key by increment.
        /// If key does not exist, a new key holding a hash is created. If field does not
        /// exist or holds a string that cannot be interpreted as integer, the value is set
        /// to 0 before the operation is performed.
        /// </summary>
        /// <typeparam name="T">data type</typeparam>
        /// <param name="command">command</param>
        /// <returns>hash increment response</returns>
        public static async Task<CacheCommandResult<HashIncrementResponse<T>>> HashIncrementAsync<T>(HashIncrementCommand<T> command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region HashGet

        /// <summary>
        /// Returns the value associated with field in the hash stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>hash get response</returns>
        public static async Task<CacheCommandResult<HashGetResponse>> HashGetAsync(HashGetCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region HashGetAll

        /// <summary>
        /// Returns all fields and values of the hash stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>hash get all response</returns>
        public static async Task<CacheCommandResult<HashGetAllResponse>> HashGetAllAsync(HashGetAllCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region HashExists

        /// <summary>
        /// Returns if field is an existing field in the hash stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>hash exists response</returns>
        public static async Task<CacheCommandResult<HashExistsResponse>> HashExistsAsync(HashExistsCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region HashDelete

        /// <summary>
        /// Removes the specified fields from the hash stored at key. Non-existing fields
        /// are ignored. Non-existing keys are treated as empty hashes and this command returns 0
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>hash delete response</returns>
        public static async Task<CacheCommandResult<HashDeleteResponse>> HashDeleteAsync(HashDeleteCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region HashDecrement

        /// <summary>
        /// Decrement the specified field of an hash stored at key, and representing a floating
        ///  point number, by the specified decrement. If the field does not exist, it is
        ///  set to 0 before performing the operation.
        /// </summary>
        /// <typeparam name="T">data type</typeparam>
        /// <param name="command">command</param>
        /// <returns>hash decrement response</returns>
        public static async Task<CacheCommandResult<HashDecrementResponse<T>>> HashDecrementAsync<T>(HashDecrementCommand<T> command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region HashScan

        /// <summary>
        /// The HSCAN command is used to incrementally iterate over a hash
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>hash scan response</returns>
        public static async Task<CacheCommandResult<HashScanResponse>> HashScanAsync(HashScanCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region sets

        #region SetRemove

        /// <summary>
        /// Remove the specified member from the set stored at key. Specified members that
        /// are not a member of this set are ignored.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set remove response</returns>
        public static async Task<CacheCommandResult<SetRemoveResponse>> SetRemoveAsync(SetRemoveCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SetRandomMembers

        /// <summary>
        /// Return an array of count distinct elements if count is positive. If called with
        /// a negative count the behavior changes and the command is allowed to return the
        /// same element multiple times. In this case the numer of returned elements is the
        /// absolute value of the specified count.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set random members response</returns>
        public static async Task<CacheCommandResult<SetRandomMembersResponse>> SetRandomMembersAsync(SetRandomMembersCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SetRandomMember

        /// <summary>
        /// Return a random element from the set value stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set random member</returns>
        public static async Task<CacheCommandResult<SetRandomMemberResponse>> SetRandomMemberAsync(SetRandomMemberCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SetPop

        /// <summary>
        /// Removes and returns a random element from the set value stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set pop response</returns>
        public static async Task<CacheCommandResult<SetPopResponse>> SetPopAsync(SetPopCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SetMove

        /// <summary>
        /// Move member from the set at source to the set at destination. This operation
        /// is atomic. In every given moment the element will appear to be a member of source
        /// or destination for other clients. When the specified element already exists in
        /// the destination set, it is only removed from the source set.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set move response</returns>
        public static async Task<CacheCommandResult<SetMoveResponse>> SetMoveAsync(SetMoveCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SetMembers

        /// <summary>
        /// Returns all the members of the set value stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set members response</returns>
        public static async Task<CacheCommandResult<SetMembersResponse>> SetMembersAsync(SetMembersCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SetLength

        /// <summary>
        /// Returns the set cardinality (number of elements) of the set stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set length response</returns>
        public static async Task<CacheCommandResult<SetLengthResponse>> SetLengthAsync(SetLengthCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SetContains

        /// <summary>
        /// Returns if member is a member of the set stored at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set contains response</returns>
        public static async Task<CacheCommandResult<SetContainsResponse>> SetContainsAsync(SetContainsCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SetCombine

        /// <summary>
        /// Returns the members of the set resulting from the specified operation against
        /// the given sets.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set combine response</returns>
        public static async Task<CacheCommandResult<SetCombineResponse>> SetCombineAsync(SetCombineCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SetCombineAndStore

        /// <summary>
        /// This command is equal to SetCombine, but instead of returning the resulting set,
        ///  it is stored in destination. If destination already exists, it is overwritten.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set combine and store response</returns>
        public static async Task<CacheCommandResult<SetCombineAndStoreResponse>> SetCombineAndStoreAsync(SetCombineAndStoreCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SetAdd

        /// <summary>
        /// Add the specified member to the set stored at key. Specified members that are
        /// already a member of this set are ignored. If key does not exist, a new set is
        /// created before adding the specified members.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>set add response</returns>
        public static async Task<CacheCommandResult<SetAddResponse>> SetAddAsync(SetAddCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region sorted set

        #region SortedSetScore

        /// <summary>
        /// Returns the score of member in the sorted set at key; If member does not exist
        /// in the sorted set, or key does not exist, nil is returned.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set score response</returns>
        public static async Task<CacheCommandResult<SortedSetScoreResponse>> SortedSetScoreAsync(SortedSetScoreCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetRemoveRangeByValue

        /// <summary>
        /// When all the elements in a sorted set are inserted with the same score, in order
        /// to force lexicographical ordering, this command removes all elements in the sorted
        /// set stored at key between the lexicographical range specified by min and max.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set remove range by value response</returns>
        public static async Task<CacheCommandResult<SortedSetRemoveRangeByValueResponse>> SortedSetRemoveRangeByValueAsync(SortedSetRemoveRangeByValueCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetRemoveRangeByScore

        /// <summary>
        /// Removes all elements in the sorted set stored at key with a score between min
        ///  and max (inclusive by default).
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set remove range by score response</returns>
        public static async Task<CacheCommandResult<SortedSetRemoveRangeByScoreResponse>> SortedSetRemoveRangeByScoreAsync(SortedSetRemoveRangeByScoreCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetRemoveRangeByRank

        /// <summary>
        /// Removes all elements in the sorted set stored at key with rank between start
        /// and stop. Both start and stop are 0 -based indexes with 0 being the element with
        /// the lowest score. These indexes can be negative numbers, where they indicate
        /// offsets starting at the element with the highest score. For example: -1 is the
        /// element with the highest score, -2 the element with the second highest score
        /// and so forth.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set remove range by rank response</returns>
        public static async Task<CacheCommandResult<SortedSetRemoveRangeByRankResponse>> SortedSetRemoveRangeByRankAsync(SortedSetRemoveRangeByRankCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetRemove

        /// <summary>
        /// Removes the specified members from the sorted set stored at key. Non existing
        /// members are ignored.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set remove response</returns>
        public static async Task<CacheCommandResult<SortedSetRemoveResponse>> SortedSetRemoveAsync(SortedSetRemoveCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetRank

        /// <summary>
        /// Returns the rank of member in the sorted set stored at key, by default with the
        /// scores ordered from low to high. The rank (or index) is 0-based, which means
        /// that the member with the lowest score has rank 0.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set rank response</returns>
        public static async Task<CacheCommandResult<SortedSetRankResponse>> SortedSetRankAsync(SortedSetRankCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetRangeByValue

        /// <summary>
        /// When all the elements in a sorted set are inserted with the same score, in order
        /// to force lexicographical ordering, this command returns all the elements in the
        /// sorted set at key with a value between min and max.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set range by value response</returns>
        public static async Task<CacheCommandResult<SortedSetRangeByValueResponse>> SortedSetRangeByValueAsync(SortedSetRangeByValueCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetRangeByScoreWithScores

        /// <summary>
        /// Returns the specified range of elements in the sorted set stored at key. By default
        /// the elements are considered to be ordered from the lowest to the highest score.
        /// Lexicographical order is used for elements with equal score. Start and stop are
        /// used to specify the min and max range for score values. Similar to other range
        /// methods the values are inclusive.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set range by score with scores response</returns>
        public static async Task<CacheCommandResult<SortedSetRangeByScoreWithScoresResponse>> SortedSetRangeByScoreWithScoresAsync(SortedSetRangeByScoreWithScoresCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetRangeByScore

        /// <summary>
        /// Returns the specified range of elements in the sorted set stored at key. By default
        /// the elements are considered to be ordered from the lowest to the highest score.
        /// Lexicographical order is used for elements with equal score. Start and stop are
        /// used to specify the min and max range for score values. Similar to other range
        /// methods the values are inclusive.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set range by score response</returns>
        public static async Task<CacheCommandResult<SortedSetRangeByScoreResponse>> SortedSetRangeByScoreAsync(SortedSetRangeByScoreCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetRangeByRankWithScores

        /// <summary>
        /// Returns the specified range of elements in the sorted set stored at key. By default
        /// the elements are considered to be ordered from the lowest to the highest score.
        /// Lexicographical order is used for elements with equal score. Both start and stop
        /// are zero-based indexes, where 0 is the first element, 1 is the next element and
        /// so on. They can also be negative numbers indicating offsets from the end of the
        /// sorted set, with -1 being the last element of the sorted set, -2 the penultimate
        /// element and so on.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set range by rank with scores response</returns>
        public static async Task<CacheCommandResult<SortedSetRangeByRankWithScoresResponse>> SortedSetRangeByRankWithScoresAsync(SortedSetRangeByRankWithScoresCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetRangeByRank

        /// <summary>
        /// Returns the specified range of elements in the sorted set stored at key. By default
        /// the elements are considered to be ordered from the lowest to the highest score.
        /// Lexicographical order is used for elements with equal score. Both start and stop
        /// are zero-based indexes, where 0 is the first element, 1 is the next element and
        /// so on. They can also be negative numbers indicating offsets from the end of the
        /// sorted set, with -1 being the last element of the sorted set, -2 the penultimate
        /// element and so on.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set range by rank response</returns>
        public static async Task<CacheCommandResult<SortedSetRangeByRankResponse>> SortedSetRangeByRankAsync(SortedSetRangeByRankCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetLengthByValue

        /// <summary>
        /// When all the elements in a sorted set are inserted with the same score, in order
        /// to force lexicographical ordering, this command returns the number of elements
        /// in the sorted set at key with a value between min and max.
        /// </summary>
        /// <param name="command">response</param>
        /// <returns>sorted set lenght by value response</returns>
        public static async Task<CacheCommandResult<SortedSetLengthByValueResponse>> SortedSetLengthByValueAsync(SortedSetLengthByValueCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetLength

        /// <summary>
        /// Returns the sorted set cardinality (number of elements) of the sorted set stored
        /// at key.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set length response</returns>
        public static async Task<CacheCommandResult<SortedSetLengthResponse>> SortedSetLengthAsync(SortedSetLengthCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetIncrement

        /// <summary>
        /// Increments the score of member in the sorted set stored at key by increment.
        /// If member does not exist in the sorted set, it is added with increment as its
        /// score (as if its previous score was 0.0).
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set increment response</returns>
        public static async Task<CacheCommandResult<SortedSetIncrementResponse>> SortedSetIncrementAsync(SortedSetIncrementCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetDecrement

        /// <summary>
        /// Decrements the score of member in the sorted set stored at key by decrement.
        /// If member does not exist in the sorted set, it is added with -decrement as its
        /// score (as if its previous score was 0.0).
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set decrement response</returns>
        public static async Task<CacheCommandResult<SortedSetDecrementResponse>> SortedSetDecrementAsync(SortedSetDecrementCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetCombineAndStore

        /// <summary>
        /// Computes a set operation over multiple sorted sets (optionally using per-set
        /// weights), and stores the result in destination, optionally performing a specific
        /// aggregation (defaults to sum)
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set combine and store response</returns>
        public static async Task<CacheCommandResult<SortedSetCombineAndStoreResponse>> SortedSetCombineAndStoreAsync(SortedSetCombineAndStoreCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortedSetAdd

        /// <summary>
        /// Adds all the specified members with the specified scores to the sorted set stored
        /// at key. If a specified member is already a member of the sorted set, the score
        /// is updated and the element reinserted at the right position to ensure the correct
        /// ordering.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sorted set add response</returns>
        public static async Task<CacheCommandResult<SortedSetAddResponse>> SortedSetAddAsync(SortedSetAddCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region sort

        #region Sort

        /// <summary>
        /// Sorts a list, set or sorted set (numerically or alphabetically, ascending by
        /// default){await Task.Delay(100);return null;} By default, the elements themselves are compared, but the values can
        /// also be used to perform external key-lookups using the by parameter. By default,
        /// the elements themselves are returned, but external key-lookups (one or many)
        /// can be performed instead by specifying the get parameter (note that # specifies
        /// the element itself, when used in get). Referring to the redis SORT documentation
        /// for examples is recommended. When used in hashes, by and get can be used to specify
        /// fields using -> notation (again, refer to redis documentation).
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sort response</returns>
        public static async Task<CacheCommandResult<SortResponse>> SortAsync(SortCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region SortAndStore

        /// <summary>
        /// Sorts a list, set or sorted set (numerically or alphabetically, ascending by
        /// default){await Task.Delay(100);return null;} By default, the elements themselves are compared, but the values can
        /// also be used to perform external key-lookups using the by parameter. By default,
        /// the elements themselves are returned, but external key-lookups (one or many)
        /// can be performed instead by specifying the get parameter (note that # specifies
        /// the element itself, when used in get). Referring to the redis SORT documentation
        /// for examples is recommended. When used in hashes, by and get can be used to specify
        /// fields using -> notation (again, refer to redis documentation).
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>sort and store response</returns>
        public static async Task<CacheCommandResult<SortAndStoreResponse>> SortAndStoreAsync(SortAndStoreCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region key

        #region KeyType

        /// <summary>
        /// Returns the string representation of the type of the value stored at key. The
        /// different types that can be returned are: string, list, set, zset and hash.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key type response</returns>
        public static async Task<CacheCommandResult<KeyTypeResponse>> KeyTypeAsync(KeyTypeCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region KeyTimeToLive

        /// <summary>
        /// Returns the remaining time to live of a key that has a timeout. This introspection
        /// capability allows a Redis client to check how many seconds a given key will continue
        /// to be part of the dataset.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key time to live response</returns>
        public static async Task<CacheCommandResult<KeyTimeToLiveResponse>> KeyTimeToLiveAsync(KeyTimeToLiveCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region KeyRestore

        /// <summary>
        /// Create a key associated with a value that is obtained by deserializing the provided
        /// serialized value (obtained via DUMP). If ttl is 0 the key is created without
        /// any expire, otherwise the specified expire time(in milliseconds) is set.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key restore response</returns>
        public static async Task<CacheCommandResult<KeyRestoreResponse>> KeyRestoreAsync(KeyRestoreCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region KeyRename

        /// <summary>
        /// Renames key to newkey. It returns an error when the source and destination names
        /// are the same, or when key does not exist.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key rename response</returns>
        public static async Task<CacheCommandResult<KeyRenameResponse>> KeyRenameAsync(KeyRenameCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region KeyRandom

        /// <summary>
        /// Return a random key from the currently selected database.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key random response</returns>
        public static async Task<CacheCommandResult<KeyRandomResponse>> KeyRandomAsync(KeyRandomCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region KeyPersist

        /// <summary>
        /// Remove the existing timeout on key, turning the key from volatile (a key with
        /// an expire set) to persistent (a key that will never expire as no timeout is associated).
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key persist response</returns>
        public static async Task<CacheCommandResult<KeyPersistResponse>> KeyPersistAsync(KeyPersistCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region KeyMove

        /// <summary>
        /// Move key from the currently selected database (see SELECT) to the specified destination
        /// database. When key already exists in the destination database, or it does not
        /// exist in the source database, it does nothing. It is possible to use MOVE as
        /// a locking primitive because of this.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key move response</returns>
        public static async Task<CacheCommandResult<KeyMoveResponse>> KeyMoveAsync(KeyMoveCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region KeyMigrate

        /// <summary>
        /// Atomically transfer a key from a source Redis instance to a destination Redis
        /// instance. On success the key is deleted from the original instance by default,
        /// and is guaranteed to exist in the target instance.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key migrate response</returns>
        public static async Task<CacheCommandResult<KeyMigrateResponse>> KeyMigrateAsync(KeyMigrateCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region KeyExpire

        /// <summary>
        /// Set a timeout on key. After the timeout has expired, the key will automatically
        /// be deleted. A key with an associated timeout is said to be volatile in Redis
        /// terminology.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key expire response</returns>
        public static async Task<CacheCommandResult<KeyExpireResponse>> KeyExpireAsync(KeyExpireCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion;

        #region KeyDump

        /// <summary>
        /// Serialize the value stored at key in a Redis-specific format and return it to
        /// the user. The returned value can be synthesized back into a Redis key using the
        /// RESTORE command.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key dump response</returns>
        public static async Task<CacheCommandResult<KeyDumpResponse>> KeyDumpAsync(KeyDumpCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region KeyDelete

        /// <summary>
        /// Removes the specified keys. A key is ignored if it does not exist.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key delete response</returns>
        public static async Task<CacheCommandResult<KeyDeleteResponse>> KeyDeleteAsync(KeyDeleteCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #region Get Keys

        /// <summary>
        /// Removes the specified keys. A key is ignored if it does not exist.
        /// </summary>
        /// <param name="command">command</param>
        /// <returns>key delete response</returns>
        public static async Task<CacheCommandResult<GetKeysResponse>> GetKeysAsync(GetKeysCommand command)
        {
            return await ExecuteCommandAsync(command).ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region execute command

        /// <summary>
        /// Execute Cache Operation
        /// </summary>
        /// <param name="command">command</param>
        /// <param name="handler">handler</param>
        /// <returns></returns>
        static async Task<CacheCommandResult<TR>> ExecuteCommandAsync<TR>(CacheCommand<TR> cacheCommand) where TR : CacheResponse
        {
            if (cacheCommand == null)
            {
                return CacheCommandResult<TR>.EmptyResult();
            }
            return await cacheCommand.ExecuteAsync().ConfigureAwait(false) ?? CacheCommandResult<TR>.EmptyResult();
        }

        #endregion

        #endregion

        #region server

        public static class Server
        {
            #region get all data base

            /// <summary>
            /// get all database
            /// </summary>
            /// <param name="server">server</param>
            /// <param name="command">command</param>
            /// <returns>get all database response</returns>
            public static async Task<CacheCommandResult<GetAllDataBaseResponse>> GetAllDataBaseAsync(CacheServer server, GetAllDataBaseCommand command)
            {
                return await command.ExecuteAsync(server).ConfigureAwait(false);
            }

            #endregion

            #region query keys

            /// <summary>
            /// query keys
            /// </summary>
            /// <param name="server">server</param>
            /// <param name="command">command</param>
            /// <returns>get keys response</returns>
            public static async Task<CacheCommandResult<GetKeysResponse>> GetKeysAsync(CacheServer server, GetKeysCommand command)
            {
                return await command.ExecuteAsync(server).ConfigureAwait(false);
            }

            #endregion

            #region clear data

            /// <summary>
            /// clear database data
            /// </summary>
            /// <param name="server">server</param>
            /// <param name="command">command</param>
            /// <returns>clear data response</returns>
            public static async Task<CacheCommandResult<ClearDataResponse>> ClearDataAsync(CacheServer server, ClearDataCommand command)
            {
                return await command.ExecuteAsync(server).ConfigureAwait(false);
            }

            #endregion

            #region get cache item detail

            /// <summary>
            /// get cache item detail
            /// </summary>
            /// <param name="server">server</param>
            /// <param name="command">command</param>
            /// <returns>get key detail response</returns>
            public static async Task<CacheCommandResult<GetKeyDetailResponse>> GetKeyDetailAsync(CacheServer server, GetKeyDetailCommand command)
            {
                return await command.ExecuteAsync(server).ConfigureAwait(false);
            }

            #endregion

            #region get server config

            /// <summary>
            /// get server config
            /// </summary>
            /// <param name="server">server</param>
            /// <param name="command">command</param>
            /// <returns>get server config response</returns>
            public static async Task<CacheCommandResult<GetServerConfigResponse>> GetServerConfigAsync(CacheServer server, GetServerConfigCommand command)
            {
                return await command.ExecuteAsync(server).ConfigureAwait(false);
            }

            #endregion

            #region save server config

            /// <summary>
            /// save server config
            /// </summary>
            /// <param name="command">command</param>
            /// <returns>save server config response</returns>
            public static async Task<CacheCommandResult<SaveServerConfigResponse>> SaveServerConfigAsync(CacheServer server, SaveServerConfigCommand command)
            {
                return await command.ExecuteAsync(server).ConfigureAwait(false);
            }

            #endregion
        }

        #endregion

        #region config

        /// <summary>
        /// cache config
        /// </summary>
        public static class Config
        {
            /// <summary>
            /// cache providers
            /// </summary>
            public static Dictionary<CacheServerType, ICacheProvider> Providers = new Dictionary<CacheServerType, ICacheProvider>();

            /// <summary>
            /// command cache server factory
            /// </summary>
            public static Func<ICacheCommand, List<CacheServer>> RequestCacheServerFactory;

            /// <summary>
            /// get command cache servers
            /// </summary>
            /// <param name="cacheCommand">cache command</param>
            /// <returns></returns>
            public static List<CacheServer> GetRequestCacheServers<T>(CacheCommand<T> cacheCommand) where T : CacheResponse
            {
                return RequestCacheServerFactory?.Invoke(cacheCommand) ?? new List<CacheServer>(0);
            }

            /// <summary>
            /// get cache provider
            /// </summary>
            /// <param name="serverType">server type</param>
            /// <returns></returns>
            public static ICacheProvider GetCacheProvider(CacheServerType serverType)
            {
                Providers.TryGetValue(serverType, out var provider);
                return provider;
            }

            /// <summary>
            /// key name splitter
            /// </summary>
            public static string KeyNameSplitter = ":";

            /// <summary>
            /// name value splitter
            /// </summary>
            public static string NameValueSplitter = "$";

            /// <summary>
            /// set global cache key prefix
            /// </summary>
            public static Func<List<string>> SetGlobalCacheKeyPrefix;

            /// <summary>
            /// set cache object key prefix
            /// </summary>
            public static Func<CacheObject, List<string>> SetCacheObjectKeyPrefix = o =>
              {
                  string objectName = o?.ObjectName;
                  if (!objectName.IsNullOrEmpty())
                  {
                      return new List<string>() { objectName };
                  }
                  return new List<string>(0);
              };
        }

        #endregion
    }
}
