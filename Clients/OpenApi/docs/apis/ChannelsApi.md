# Org.OpenAPITools.Api.ChannelsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddReactionToMessageApiV1ChannelsIdMessagesMessageIdReactionsAddPost**](ChannelsApi.md#addreactiontomessageapiv1channelsidmessagesmessageidreactionsaddpost) | **POST** /api/v1/channels/{id}/messages/{message_id}/reactions/add | Add Reaction To Message |
| [**CreateNewChannelApiV1ChannelsCreatePost**](ChannelsApi.md#createnewchannelapiv1channelscreatepost) | **POST** /api/v1/channels/create | Create New Channel |
| [**DeleteChannelByIdApiV1ChannelsIdDeleteDelete**](ChannelsApi.md#deletechannelbyidapiv1channelsiddeletedelete) | **DELETE** /api/v1/channels/{id}/delete | Delete Channel By Id |
| [**DeleteMessageByIdApiV1ChannelsIdMessagesMessageIdDeleteDelete**](ChannelsApi.md#deletemessagebyidapiv1channelsidmessagesmessageiddeletedelete) | **DELETE** /api/v1/channels/{id}/messages/{message_id}/delete | Delete Message By Id |
| [**GetChannelByIdApiV1ChannelsIdGet**](ChannelsApi.md#getchannelbyidapiv1channelsidget) | **GET** /api/v1/channels/{id} | Get Channel By Id |
| [**GetChannelMessageApiV1ChannelsIdMessagesMessageIdGet**](ChannelsApi.md#getchannelmessageapiv1channelsidmessagesmessageidget) | **GET** /api/v1/channels/{id}/messages/{message_id} | Get Channel Message |
| [**GetChannelMessagesApiV1ChannelsIdMessagesGet**](ChannelsApi.md#getchannelmessagesapiv1channelsidmessagesget) | **GET** /api/v1/channels/{id}/messages | Get Channel Messages |
| [**GetChannelThreadMessagesApiV1ChannelsIdMessagesMessageIdThreadGet**](ChannelsApi.md#getchannelthreadmessagesapiv1channelsidmessagesmessageidthreadget) | **GET** /api/v1/channels/{id}/messages/{message_id}/thread | Get Channel Thread Messages |
| [**GetChannelsApiV1ChannelsGet**](ChannelsApi.md#getchannelsapiv1channelsget) | **GET** /api/v1/channels/ | Get Channels |
| [**PostNewMessageApiV1ChannelsIdMessagesPostPost**](ChannelsApi.md#postnewmessageapiv1channelsidmessagespostpost) | **POST** /api/v1/channels/{id}/messages/post | Post New Message |
| [**RemoveReactionByIdAndUserIdAndNameApiV1ChannelsIdMessagesMessageIdReactionsRemovePost**](ChannelsApi.md#removereactionbyidanduseridandnameapiv1channelsidmessagesmessageidreactionsremovepost) | **POST** /api/v1/channels/{id}/messages/{message_id}/reactions/remove | Remove Reaction By Id And User Id And Name |
| [**UpdateChannelByIdApiV1ChannelsIdUpdatePost**](ChannelsApi.md#updatechannelbyidapiv1channelsidupdatepost) | **POST** /api/v1/channels/{id}/update | Update Channel By Id |
| [**UpdateMessageByIdApiV1ChannelsIdMessagesMessageIdUpdatePost**](ChannelsApi.md#updatemessagebyidapiv1channelsidmessagesmessageidupdatepost) | **POST** /api/v1/channels/{id}/messages/{message_id}/update | Update Message By Id |

<a id="addreactiontomessageapiv1channelsidmessagesmessageidreactionsaddpost"></a>
# **AddReactionToMessageApiV1ChannelsIdMessagesMessageIdReactionsAddPost**
> bool AddReactionToMessageApiV1ChannelsIdMessagesMessageIdReactionsAddPost (string id, string messageId, ReactionForm reactionForm)

Add Reaction To Message


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **messageId** | **string** |  |  |
| **reactionForm** | [**ReactionForm**](ReactionForm.md) |  |  |

### Return type

**bool**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createnewchannelapiv1channelscreatepost"></a>
# **CreateNewChannelApiV1ChannelsCreatePost**
> ChannelModel CreateNewChannelApiV1ChannelsCreatePost (ChannelForm channelForm)

Create New Channel


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelForm** | [**ChannelForm**](ChannelForm.md) |  |  |

### Return type

[**ChannelModel**](ChannelModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletechannelbyidapiv1channelsiddeletedelete"></a>
# **DeleteChannelByIdApiV1ChannelsIdDeleteDelete**
> bool DeleteChannelByIdApiV1ChannelsIdDeleteDelete (string id)

Delete Channel By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**bool**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletemessagebyidapiv1channelsidmessagesmessageiddeletedelete"></a>
# **DeleteMessageByIdApiV1ChannelsIdMessagesMessageIdDeleteDelete**
> bool DeleteMessageByIdApiV1ChannelsIdMessagesMessageIdDeleteDelete (string id, string messageId)

Delete Message By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **messageId** | **string** |  |  |

### Return type

**bool**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannelbyidapiv1channelsidget"></a>
# **GetChannelByIdApiV1ChannelsIdGet**
> ChannelModel GetChannelByIdApiV1ChannelsIdGet (string id)

Get Channel By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ChannelModel**](ChannelModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannelmessageapiv1channelsidmessagesmessageidget"></a>
# **GetChannelMessageApiV1ChannelsIdMessagesMessageIdGet**
> MessageUserResponse GetChannelMessageApiV1ChannelsIdMessagesMessageIdGet (string id, string messageId)

Get Channel Message


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **messageId** | **string** |  |  |

### Return type

[**MessageUserResponse**](MessageUserResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannelmessagesapiv1channelsidmessagesget"></a>
# **GetChannelMessagesApiV1ChannelsIdMessagesGet**
> List&lt;MessageUserResponse&gt; GetChannelMessagesApiV1ChannelsIdMessagesGet (string id, int skip = null, int limit = null)

Get Channel Messages


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **skip** | **int** |  | [optional] [default to 0] |
| **limit** | **int** |  | [optional] [default to 50] |

### Return type

[**List&lt;MessageUserResponse&gt;**](MessageUserResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannelthreadmessagesapiv1channelsidmessagesmessageidthreadget"></a>
# **GetChannelThreadMessagesApiV1ChannelsIdMessagesMessageIdThreadGet**
> List&lt;MessageUserResponse&gt; GetChannelThreadMessagesApiV1ChannelsIdMessagesMessageIdThreadGet (string id, string messageId, int skip = null, int limit = null)

Get Channel Thread Messages


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **messageId** | **string** |  |  |
| **skip** | **int** |  | [optional] [default to 0] |
| **limit** | **int** |  | [optional] [default to 50] |

### Return type

[**List&lt;MessageUserResponse&gt;**](MessageUserResponse.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getchannelsapiv1channelsget"></a>
# **GetChannelsApiV1ChannelsGet**
> List&lt;ChannelModel&gt; GetChannelsApiV1ChannelsGet ()

Get Channels


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ChannelModel&gt;**](ChannelModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="postnewmessageapiv1channelsidmessagespostpost"></a>
# **PostNewMessageApiV1ChannelsIdMessagesPostPost**
> MessageModel PostNewMessageApiV1ChannelsIdMessagesPostPost (string id, OpenWebuiModelsMessagesMessageForm openWebuiModelsMessagesMessageForm)

Post New Message


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **openWebuiModelsMessagesMessageForm** | [**OpenWebuiModelsMessagesMessageForm**](OpenWebuiModelsMessagesMessageForm.md) |  |  |

### Return type

[**MessageModel**](MessageModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="removereactionbyidanduseridandnameapiv1channelsidmessagesmessageidreactionsremovepost"></a>
# **RemoveReactionByIdAndUserIdAndNameApiV1ChannelsIdMessagesMessageIdReactionsRemovePost**
> bool RemoveReactionByIdAndUserIdAndNameApiV1ChannelsIdMessagesMessageIdReactionsRemovePost (string id, string messageId, ReactionForm reactionForm)

Remove Reaction By Id And User Id And Name


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **messageId** | **string** |  |  |
| **reactionForm** | [**ReactionForm**](ReactionForm.md) |  |  |

### Return type

**bool**

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatechannelbyidapiv1channelsidupdatepost"></a>
# **UpdateChannelByIdApiV1ChannelsIdUpdatePost**
> ChannelModel UpdateChannelByIdApiV1ChannelsIdUpdatePost (string id, ChannelForm channelForm)

Update Channel By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **channelForm** | [**ChannelForm**](ChannelForm.md) |  |  |

### Return type

[**ChannelModel**](ChannelModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatemessagebyidapiv1channelsidmessagesmessageidupdatepost"></a>
# **UpdateMessageByIdApiV1ChannelsIdMessagesMessageIdUpdatePost**
> MessageModel UpdateMessageByIdApiV1ChannelsIdMessagesMessageIdUpdatePost (string id, string messageId, OpenWebuiModelsMessagesMessageForm openWebuiModelsMessagesMessageForm)

Update Message By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **messageId** | **string** |  |  |
| **openWebuiModelsMessagesMessageForm** | [**OpenWebuiModelsMessagesMessageForm**](OpenWebuiModelsMessagesMessageForm.md) |  |  |

### Return type

[**MessageModel**](MessageModel.md)

### Authorization

[HTTPBearer](../README.md#HTTPBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

