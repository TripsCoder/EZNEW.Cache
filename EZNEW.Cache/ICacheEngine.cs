using EZNEW.Cache.Request;
using EZNEW.Cache.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNEW.Cache
{
    /// <summary>
    /// cache engine interface
    /// </summary>
    public interface ICacheEngine
    {
        #region string

        #region StringSetRange

        /// <summary>
        /// Overwrites part of the string stored at key, starting at the specified offset,
        /// for the entire length of value. If the offset is larger than the current length
        /// of the string at key, the string is padded with zero-bytes to make offset fit.
        /// Non-existing keys are considered as empty strings, so this command will make
        /// sure it holds a string large enough to be able to set value at offset.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>string set range response</returns>
        Task<StringSetRangeResponse> StringSetRangeAsync(StringSetRangeRequest request);

        #endregion

        #region StringSetBit

        /// <summary>
        /// Sets or clears the bit at offset in the string value stored at key. The bit is
        /// either set or cleared depending on value, which can be either 0 or 1. When key
        /// does not exist, a new string value is created.The string is grown to make sure
        /// it can hold a bit at offset.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>string set bit response</returns>
        Task<StringSetBitResponse> StringSetBitAsync(StringSetBitRequest request);

        #endregion

        #region StringSet

        /// <summary>
        /// Set key to hold the string value. If key already holds a value, it is overwritten,
        /// regardless of its type.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>string set response</returns>
        Task<StringSetResponse> StringSetAsync(StringSetRequest request);

        #endregion

        #region StringLength

        /// <summary>
        /// Returns the length of the string value stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>string length response</returns>
        Task<StringLengthResponse> StringLengthAsync(StringLengthRequest request);

        #endregion

        #region StringIncrement

        /// <summary>
        /// Increments the string representing a floating point number stored at key by the
        /// specified increment. If the key does not exist, it is set to 0 before performing
        /// the operation. The precision of the output is fixed at 17 digits after the decimal
        /// point regardless of the actual internal precision of the computation.
        /// </summary>
        /// <typeparam name="T">data type</typeparam>
        /// <param name="request">request</param>
        /// <returns>string increment response</returns>
        Task<StringIncrementResponse<T>> StringIncrementAsync<T>(StringIncrementRequest<T> request);

        #endregion

        #region StringGetWithExpiry

        /// <summary>
        /// Get the value of key. If the key does not exist the special value nil is returned.
        /// An error is returned if the value stored at key is not a string, because GET
        /// only handles string values.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>string get with expiry response</returns>
        Task<StringGetWithExpiryResponse> StringGetWithExpiryAsync(StringGetWithExpiryRequest request);

        #endregion

        #region StringGetSet

        /// <summary>
        /// Atomically sets key to value and returns the old value stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>string get set response</returns>
        Task<StringGetSetResponse> StringGetSetAsync(StringGetSetRequest request);

        #endregion

        #region StringGetRange

        /// <summary>
        /// Returns the substring of the string value stored at key, determined by the offsets
        /// start and end (both are inclusive). Negative offsets can be used in order to
        /// provide an offset starting from the end of the string. So -1 means the last character,
        /// -2 the penultimate and so forth.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>string get range response</returns>
        Task<StringGetRangeResponse> StringGetRangeAsync(StringGetRangeRequest request);

        #endregion

        #region StringGetBit

        /// <summary>
        /// Returns the bit value at offset in the string value stored at key. When offset
        /// is beyond the string length, the string is assumed to be a contiguous space with
        /// 0 bits
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>string get bit response</returns>
        Task<StringGetBitResponse> StringGetBitAsync(StringGetBitRequest request);

        #endregion

        #region StringGet

        /// <summary>
        /// Returns the values of all specified keys. For every key that does not hold a
        /// string value or does not exist, the special value nil is returned.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>string get response</returns>
        Task<StringGetResponse> StringGetAsync(StringGetRequest request);

        #endregion

        #region StringDecrement

        /// <summary>
        /// Decrements the number stored at key by decrement. If the key does not exist,
        /// it is set to 0 before performing the operation. An error is returned if the key
        /// contains a value of the wrong type or contains a string that is not representable
        /// as integer. This operation is limited to 64 bit signed integers.
        /// </summary>
        /// <typeparam name="T">data type</typeparam>
        /// <param name="request">request</param>
        /// <returns>string decrement response</returns>
        Task<StringDecrementResponse<T>> StringDecrementAsync<T>(StringDecrementRequest<T> request);

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
        /// <param name="request">request</param>
        /// <returns>string bit position response</returns>
        Task<StringBitPositionResponse> StringBitPositionAsync(StringBitPositionRequest request);

        #endregion

        #region StringBitOperation

        /// <summary>
        /// Perform a bitwise operation between multiple keys (containing string values)
        ///  and store the result in the destination key. The BITOP command supports four
        ///  bitwise operations; note that NOT is a unary operator: the second key should
        ///  be omitted in this case and only the first key will be considered. The result
        /// of the operation is always stored at destkey.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>string bit operation response</returns>
        Task<StringBitOperationResponse> StringBitOperationAsync(StringBitOperationRequest request);

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
        /// <param name="request">request</param>
        /// <returns>string bit count response</returns>
        Task<StringBitCountResponse> StringBitCountAsync(StringBitCountRequest request);

        #endregion

        #region StringAppend

        /// <summary>
        /// If key already exists and is a string, this command appends the value at the
        /// end of the string. If key does not exist it is created and set as an empty string,
        /// so APPEND will be similar to SET in this special case.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>string append response</returns>
        Task<StringAppendResponse> StringAppendAsync(StringAppendRequest request);

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
        /// <param name="request">request</param>
        /// <returns>list trim response</returns>
        Task<ListTrimResponse> ListTrimAsync(ListTrimRequest request);

        #endregion

        #region ListSetByIndex

        /// <summary>
        /// Sets the list element at index to value. For more information on the index argument,
        ///  see ListGetByIndex. An error is returned for out of range indexes.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>list set by index response</returns>
        Task<ListSetByIndexResponse> ListSetByIndexAsync(ListSetByIndexRequest request);

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
        /// <param name="request">request</param>
        /// <returns>list right push</returns>
        Task<ListRightPushResponse> ListRightPushAsync(ListRightPushRequest request);

        #endregion

        #region ListRightPopLeftPush

        /// <summary>
        /// Atomically returns and removes the last element (tail) of the list stored at
        /// source, and pushes the element at the first element (head) of the list stored
        /// at destination.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>list right pop left response</returns>
        Task<ListRightPopLeftPushResponse> ListRightPopLeftPushAsync(ListRightPopLeftPushRequest request);

        #endregion

        #region ListRightPop

        /// <summary>
        /// Removes and returns the last element of the list stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>list right pop response</returns>
        Task<ListRightPopResponse> ListRightPopAsync(ListRightPopRequest request);

        #endregion

        #region ListRemove

        /// <summary>
        /// Removes the first count occurrences of elements equal to value from the list
        /// stored at key. The count argument influences the operation in the following way
        /// count > 0: Remove elements equal to value moving from head to tail. count less 0:
        /// Remove elements equal to value moving from tail to head. count = 0: Remove all
        /// elements equal to value.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>list remove response</returns>
        Task<ListRemoveResponse> ListRemoveAsync(ListRemoveRequest request);

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
        /// <param name="request">request</param>
        /// <returns>list range response</returns>
        Task<ListRangeResponse> ListRangeAsync(ListRangeRequest request);

        #endregion

        #region ListLength

        /// <summary>
        /// Returns the length of the list stored at key. If key does not exist, it is interpreted
        ///  as an empty list and 0 is returned.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>list length response</returns>
        Task<ListLengthResponse> ListLengthAsync(ListLengthRequest request);

        #endregion

        #region ListLeftPush

        /// <summary>
        /// Insert the specified value at the head of the list stored at key. If key does
        ///  not exist, it is created as empty list before performing the push operations.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>list left push response</returns>
        Task<ListLeftPushResponse> ListLeftPushAsync(ListLeftPushRequest request);

        #endregion

        #region ListLeftPop

        /// <summary>
        /// Removes and returns the first element of the list stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>list left pop response</returns>
        Task<ListLeftPopResponse> ListLeftPopAsync(ListLeftPopRequest request);

        #endregion

        #region ListInsertBefore

        /// <summary>
        /// Inserts value in the list stored at key either before or after the reference
        /// value pivot. When key does not exist, it is considered an empty list and no operation
        /// is performed.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>list insert begore response</returns>
        Task<ListInsertBeforeResponse> ListInsertBeforeAsync(ListInsertBeforeRequest request);

        #endregion

        #region ListInsertAfter

        /// <summary>
        /// Inserts value in the list stored at key either before or after the reference
        /// value pivot. When key does not exist, it is considered an empty list and no operation
        /// is performed.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>list insert after response</returns>
        Task<ListInsertAfterResponse> ListInsertAfterAsync(ListInsertAfterRequest request);

        #endregion

        #region ListGetByIndex

        /// <summary>
        /// Returns the element at index index in the list stored at key. The index is zero-based,
        /// so 0 means the first element, 1 the second element and so on. Negative indices
        /// can be used to designate elements starting at the tail of the list. Here, -1
        /// means the last element, -2 means the penultimate and so forth.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>list get by index response</returns>
        Task<ListGetByIndexResponse> ListGetByIndexAsync(ListGetByIndexRequest request);

        #endregion

        #endregion

        #region Hash

        #region HashValues

        /// <summary>
        /// Returns all values in the hash stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>hash values response</returns>
        Task<HashValuesResponse> HashValuesAsync(HashValuesRequest request);

        #endregion

        #region HashSet

        /// <summary>
        /// Sets field in the hash stored at key to value. If key does not exist, a new key
        ///  holding a hash is created. If field already exists in the hash, it is overwritten.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>hash set response</returns>
        Task<HashSetResponse> HashSetAsync(HashSetRequest request);

        #endregion

        #region HashLength

        /// <summary>
        /// Returns the number of fields contained in the hash stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>hash length response</returns>
        Task<HashLengthResponse> HashLengthAsync(HashLengthRequest request);

        #endregion

        #region HashKeys

        /// <summary>
        /// Returns all field names in the hash stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>hash keys response</returns>
        Task<HashKeysResponse> HashKeysAsync(HashKeysRequest request);

        #endregion

        #region HashIncrement

        /// <summary>
        /// Increments the number stored at field in the hash stored at key by increment.
        /// If key does not exist, a new key holding a hash is created. If field does not
        /// exist or holds a string that cannot be interpreted as integer, the value is set
        /// to 0 before the operation is performed.
        /// </summary>
        /// <typeparam name="T">data type</typeparam>
        /// <param name="request">request</param>
        /// <returns>hash increment response</returns>
        Task<HashIncrementResponse<T>> HashIncrementAsync<T>(HashIncrementRequest<T> request);

        #endregion

        #region HashGet

        /// <summary>
        /// Returns the value associated with field in the hash stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>hash get response</returns>
        Task<HashGetResponse> HashGetAsync(HashGetRequest request);

        #endregion

        #region HashGetAll

        /// <summary>
        /// Returns all fields and values of the hash stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>hash get all response</returns>
        Task<HashGetAllResponse> HashGetAllAsync(HashGetAllRequest request);

        #endregion

        #region HashExists

        /// <summary>
        /// Returns if field is an existing field in the hash stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>hash exists response</returns>
        Task<HashExistsResponse> HashExistsAsync(HashExistsRequest request);

        #endregion

        #region HashDelete

        /// <summary>
        /// Removes the specified fields from the hash stored at key. Non-existing fields
        /// are ignored. Non-existing keys are treated as empty hashes and this command returns 0
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>hash delete response</returns>
        Task<HashDeleteResponse> HashDeleteAsync(HashDeleteRequest request);

        #endregion

        #region HashDecrement

        /// <summary>
        /// Decrement the specified field of an hash stored at key, and representing a floating
        ///  point number, by the specified decrement. If the field does not exist, it is
        ///  set to 0 before performing the operation.
        /// </summary>
        /// <typeparam name="T">data type</typeparam>
        /// <param name="request">request</param>
        /// <returns>hash decrement response</returns>
        Task<HashDecrementResponse<T>> HashDecrementAsync<T>(HashDecrementRequest<T> request);

        #endregion

        #region HashScan

        /// <summary>
        /// The HSCAN command is used to incrementally iterate over a hash
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>hash scan response</returns>
        Task<HashScanResponse> HashScanAsync(HashScanRequest request);

        #endregion

        #endregion

        #region sets

        #region SetRemove

        /// <summary>
        /// Remove the specified member from the set stored at key. Specified members that
        /// are not a member of this set are ignored.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set remove response</returns>
        Task<SetRemoveResponse> SetRemoveAsync(SetRemoveRequest request);

        #endregion

        #region SetRandomMembers

        /// <summary>
        /// Return an array of count distinct elements if count is positive. If called with
        /// a negative count the behavior changes and the command is allowed to return the
        /// same element multiple times. In this case the numer of returned elements is the
        /// absolute value of the specified count.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set random members response</returns>
        Task<SetRandomMembersResponse> SetRandomMembersAsync(SetRandomMembersRequest request);

        #endregion

        #region SetRandomMember

        /// <summary>
        /// Return a random element from the set value stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set random member</returns>
        Task<SetRandomMemberResponse> SetRandomMemberAsync(SetRandomMemberRequest request);

        #endregion

        #region SetPop

        /// <summary>
        /// Removes and returns a random element from the set value stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set pop response</returns>
        Task<SetPopResponse> SetPopAsync(SetPopRequest request);

        #endregion

        #region SetMove

        /// <summary>
        /// Move member from the set at source to the set at destination. This operation
        /// is atomic. In every given moment the element will appear to be a member of source
        /// or destination for other clients. When the specified element already exists in
        /// the destination set, it is only removed from the source set.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set move response</returns>
        Task<SetMoveResponse> SetMoveAsync(SetMoveRequest request);

        #endregion

        #region SetMembers

        /// <summary>
        /// Returns all the members of the set value stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set members response</returns>
        Task<SetMembersResponse> SetMembersAsync(SetMembersRequest request);

        #endregion

        #region SetLength

        /// <summary>
        /// Returns the set cardinality (number of elements) of the set stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set length response</returns>
        Task<SetLengthResponse> SetLengthAsync(SetLengthRequest request);

        #endregion

        #region SetContains

        /// <summary>
        /// Returns if member is a member of the set stored at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set contains response</returns>
        Task<SetContainsResponse> SetContainsAsync(SetContainsRequest request);

        #endregion

        #region SetCombine

        /// <summary>
        /// Returns the members of the set resulting from the specified operation against
        /// the given sets.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set combine response</returns>
        Task<SetCombineResponse> SetCombineAsync(SetCombineRequest request);

        #endregion

        #region SetCombineAndStore

        /// <summary>
        /// This command is equal to SetCombine, but instead of returning the resulting set,
        ///  it is stored in destination. If destination already exists, it is overwritten.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set combine and store response</returns>
        Task<SetCombineAndStoreResponse> SetCombineAndStoreAsync(SetCombineAndStoreRequest request);

        #endregion

        #region SetAdd

        /// <summary>
        /// Add the specified member to the set stored at key. Specified members that are
        /// already a member of this set are ignored. If key does not exist, a new set is
        /// created before adding the specified members.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>set add response</returns>
        Task<SetAddResponse> SetAddAsync(SetAddRequest request);

        #endregion

        #endregion

        #region sorted set

        #region SortedSetScore

        /// <summary>
        /// Returns the score of member in the sorted set at key; If member does not exist
        /// in the sorted set, or key does not exist, nil is returned.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set score response</returns>
        Task<SortedSetScoreResponse> SortedSetScoreAsync(SortedSetScoreRequest request);

        #endregion

        #region SortedSetRemoveRangeByValue

        /// <summary>
        /// When all the elements in a sorted set are inserted with the same score, in order
        /// to force lexicographical ordering, this command removes all elements in the sorted
        /// set stored at key between the lexicographical range specified by min and max.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set remove range by value response</returns>
        Task<SortedSetRemoveRangeByValueResponse> SortedSetRemoveRangeByValueAsync(SortedSetRemoveRangeByValueRequest request);

        #endregion

        #region SortedSetRemoveRangeByScore

        /// <summary>
        /// Removes all elements in the sorted set stored at key with a score between min
        ///  and max (inclusive by default).
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set remove range by score response</returns>
        Task<SortedSetRemoveRangeByScoreResponse> SortedSetRemoveRangeByScoreAsync(SortedSetRemoveRangeByScoreRequest request);

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
        /// <param name="request">request</param>
        /// <returns>sorted set remove range by rank response</returns>
        Task<SortedSetRemoveRangeByRankResponse> SortedSetRemoveRangeByRankAsync(SortedSetRemoveRangeByRankRequest request);

        #endregion

        #region SortedSetRemove

        /// <summary>
        /// Removes the specified members from the sorted set stored at key. Non existing
        /// members are ignored.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set remove response</returns>
        Task<SortedSetRemoveResponse> SortedSetRemoveAsync(SortedSetRemoveRequest request);

        #endregion

        #region SortedSetRank

        /// <summary>
        /// Returns the rank of member in the sorted set stored at key, by default with the
        /// scores ordered from low to high. The rank (or index) is 0-based, which means
        /// that the member with the lowest score has rank 0.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set rank response</returns>
        Task<SortedSetRankResponse> SortedSetRankAsync(SortedSetRankRequest request);

        #endregion

        #region SortedSetRangeByValue

        /// <summary>
        /// When all the elements in a sorted set are inserted with the same score, in order
        /// to force lexicographical ordering, this command returns all the elements in the
        /// sorted set at key with a value between min and max.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set range by value response</returns>
        Task<SortedSetRangeByValueResponse> SortedSetRangeByValueAsync(SortedSetRangeByValueRequest request);

        #endregion

        #region SortedSetRangeByScoreWithScores

        /// <summary>
        /// Returns the specified range of elements in the sorted set stored at key. By default
        /// the elements are considered to be ordered from the lowest to the highest score.
        /// Lexicographical order is used for elements with equal score. Start and stop are
        /// used to specify the min and max range for score values. Similar to other range
        /// methods the values are inclusive.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set range by score with scores response</returns>
        Task<SortedSetRangeByScoreWithScoresResponse> SortedSetRangeByScoreWithScoresAsync(SortedSetRangeByScoreWithScoresRequest request);

        #endregion

        #region SortedSetRangeByScore

        /// <summary>
        /// Returns the specified range of elements in the sorted set stored at key. By default
        /// the elements are considered to be ordered from the lowest to the highest score.
        /// Lexicographical order is used for elements with equal score. Start and stop are
        /// used to specify the min and max range for score values. Similar to other range
        /// methods the values are inclusive.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set range by score response</returns>
        Task<SortedSetRangeByScoreResponse> SortedSetRangeByScoreAsync(SortedSetRangeByScoreRequest request);

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
        /// <param name="request">request</param>
        /// <returns>sorted set range by rank with scores response</returns>
        Task<SortedSetRangeByRankWithScoresResponse> SortedSetRangeByRankWithScoresAsync(SortedSetRangeByRankWithScoresRequest request);

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
        /// <param name="request">request</param>
        /// <returns>sorted set range by rank response</returns>
        Task<SortedSetRangeByRankResponse> SortedSetRangeByRankAsync(SortedSetRangeByRankRequest request);

        #endregion

        #region SortedSetLengthByValue

        /// <summary>
        /// When all the elements in a sorted set are inserted with the same score, in order
        /// to force lexicographical ordering, this command returns the number of elements
        /// in the sorted set at key with a value between min and max.
        /// </summary>
        /// <param name="request">response</param>
        /// <returns>sorted set lenght by value response</returns>
        Task<SortedSetLengthByValueResponse> SortedSetLengthByValueAsync(SortedSetLengthByValueRequest request);

        #endregion

        #region SortedSetLength

        /// <summary>
        /// Returns the sorted set cardinality (number of elements) of the sorted set stored
        /// at key.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set length response</returns>
        Task<SortedSetLengthResponse> SortedSetLengthAsync(SortedSetLengthRequest request);

        #endregion

        #region SortedSetIncrement

        /// <summary>
        /// Increments the score of member in the sorted set stored at key by increment.
        /// If member does not exist in the sorted set, it is added with increment as its
        /// score (as if its previous score was 0.0).
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set increment response</returns>
        Task<SortedSetIncrementResponse> SortedSetIncrementAsync(SortedSetIncrementRequest request);

        #endregion

        #region SortedSetDecrement

        /// <summary>
        /// Decrements the score of member in the sorted set stored at key by decrement.
        /// If member does not exist in the sorted set, it is added with -decrement as its
        /// score (as if its previous score was 0.0).
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set decrement response</returns>
        Task<SortedSetDecrementResponse> SortedSetDecrementAsync(SortedSetDecrementRequest request);

        #endregion

        #region SortedSetCombineAndStore

        /// <summary>
        /// Computes a set operation over multiple sorted sets (optionally using per-set
        /// weights), and stores the result in destination, optionally performing a specific
        /// aggregation (defaults to sum)
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set combine and store response</returns>
        Task<SortedSetCombineAndStoreResponse> SortedSetCombineAndStoreAsync(SortedSetCombineAndStoreRequest request);

        #endregion

        #region SortedSetAdd

        /// <summary>
        /// Adds all the specified members with the specified scores to the sorted set stored
        /// at key. If a specified member is already a member of the sorted set, the score
        /// is updated and the element reinserted at the right position to ensure the correct
        /// ordering.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sorted set add response</returns>
        Task<SortedSetAddResponse> SortedSetAddAsync(SortedSetAddRequest request);

        #endregion

        #endregion

        #region sort

        #region Sort

        /// <summary>
        /// Sorts a list, set or sorted set (numerically or alphabetically, ascending by
        /// default); By default, the elements themselves are compared, but the values can
        /// also be used to perform external key-lookups using the by parameter. By default,
        /// the elements themselves are returned, but external key-lookups (one or many)
        /// can be performed instead by specifying the get parameter (note that # specifies
        /// the element itself, when used in get). Referring to the redis SORT documentation
        /// for examples is recommended. When used in hashes, by and get can be used to specify
        /// fields using -> notation (again, refer to redis documentation).
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sort response</returns>
        Task<SortResponse> SortAsync(SortRequest request);

        #endregion

        #region SortAndStore

        /// <summary>
        /// Sorts a list, set or sorted set (numerically or alphabetically, ascending by
        /// default); By default, the elements themselves are compared, but the values can
        /// also be used to perform external key-lookups using the by parameter. By default,
        /// the elements themselves are returned, but external key-lookups (one or many)
        /// can be performed instead by specifying the get parameter (note that # specifies
        /// the element itself, when used in get). Referring to the redis SORT documentation
        /// for examples is recommended. When used in hashes, by and get can be used to specify
        /// fields using -> notation (again, refer to redis documentation).
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>sort and store response</returns>
        Task<SortAndStoreResponse> SortAndStoreAsync(SortAndStoreRequest request);

        #endregion

        #endregion

        #region key

        #region KeyType

        /// <summary>
        /// Returns the string representation of the type of the value stored at key. The
        /// different types that can be returned are: string, list, set, zset and hash.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key type response</returns>
        Task<KeyTypeResponse> KeyTypeAsync(KeyTypeRequest request);

        #endregion

        #region KeyTimeToLive

        /// <summary>
        /// Returns the remaining time to live of a key that has a timeout. This introspection
        /// capability allows a Redis client to check how many seconds a given key will continue
        /// to be part of the dataset.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key time to live response</returns>
        Task<KeyTimeToLiveResponse> KeyTimeToLiveAsync(KeyTimeToLiveRequest request);

        #endregion

        #region KeyRestore

        /// <summary>
        /// Create a key associated with a value that is obtained by deserializing the provided
        /// serialized value (obtained via DUMP). If ttl is 0 the key is created without
        /// any expire, otherwise the specified expire time(in milliseconds) is set.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key restore response</returns>
        Task<KeyRestoreResponse> KeyRestoreAsync(KeyRestoreRequest request);

        #endregion

        #region KeyRename

        /// <summary>
        /// Renames key to newkey. It returns an error when the source and destination names
        /// are the same, or when key does not exist.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key rename response</returns>
        Task<KeyRenameResponse> KeyRenameAsync(KeyRenameRequest request);

        #endregion

        #region KeyRandom

        /// <summary>
        /// Return a random key from the currently selected database.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key random response</returns>
        Task<KeyRandomResponse> KeyRandomAsync(KeyRandomRequest request);

        #endregion

        #region KeyPersist

        /// <summary>
        /// Remove the existing timeout on key, turning the key from volatile (a key with
        /// an expire set) to persistent (a key that will never expire as no timeout is associated).
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key persist response</returns>
        Task<KeyPersistResponse> KeyPersistAsync(KeyPersistRequest request);

        #endregion

        #region KeyMove

        /// <summary>
        /// Move key from the currently selected database (see SELECT) to the specified destination
        /// database. When key already exists in the destination database, or it does not
        /// exist in the source database, it does nothing. It is possible to use MOVE as
        /// a locking primitive because of this.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key move response</returns>
        Task<KeyMoveResponse> KeyMoveAsync(KeyMoveRequest request);

        #endregion

        #region KeyMigrate

        /// <summary>
        /// Atomically transfer a key from a source Redis instance to a destination Redis
        /// instance. On success the key is deleted from the original instance by default,
        /// and is guaranteed to exist in the target instance.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key migrate response</returns>
        Task<KeyMigrateResponse> KeyMigrateAsync(KeyMigrateRequest request);

        #endregion

        #region KeyExpire

        /// <summary>
        /// Set a timeout on key. After the timeout has expired, the key will automatically
        /// be deleted. A key with an associated timeout is said to be volatile in Redis
        /// terminology.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key expire response</returns>
        Task<KeyExpireResponse> KeyExpireAsync(KeyExpireRequest request);

        #endregion;

        #region KeyDump

        /// <summary>
        /// Serialize the value stored at key in a Redis-specific format and return it to
        /// the user. The returned value can be synthesized back into a Redis key using the
        /// RESTORE command.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key dump response</returns>
        Task<KeyDumpResponse> KeyDumpAsync(KeyDumpRequest request);

        #endregion

        #region KeyDelete

        /// <summary>
        /// Removes the specified keys. A key is ignored if it does not exist.
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>key delete response</returns>
        Task<KeyDeleteResponse> KeyDeleteAsync(KeyDeleteRequest request);

        #endregion

        #endregion

        #region server command

        #region get all data base

        /// <summary>
        /// get all database
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>get all database response</returns>
        Task<GetAllDataBaseResponse> GetAllDataBaseAsync(GetAllDataBaseRequest request);

        #endregion

        #region query keys

        /// <summary>
        /// query keys
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>get keys response</returns>
        Task<GetKeysResponse> GetKeysAsync(GetKeysRequest request);

        #endregion

        #region clear data

        /// <summary>
        /// clear database data
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>clear data response</returns>
        Task<ClearDataResponse> ClearDataAsync(ClearDataRequest request);

        #endregion

        #region get cache item detail

        /// <summary>
        /// get cache item detail
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>get key detail response</returns>
        Task<GetKeyDetailResponse> GetKeyDetailAsync(GetKeyDetailRequest request);

        #endregion

        #region get server config

        /// <summary>
        /// get server config
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>get server config response</returns>
        Task<GetServerConfigResponse> GetServerConfigAsync(GetServerConfigRequest request);

        #endregion

        #region save server config

        /// <summary>
        /// save server config
        /// </summary>
        /// <param name="request">request</param>
        /// <returns>save server config response</returns>
        Task<SaveServerConfigResponse> SaveServerConfigAsync(SaveServerConfigRequest request);

        #endregion

        #endregion
    }
}
