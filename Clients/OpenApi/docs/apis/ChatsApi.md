# Org.OpenAPITools.Api.ChatsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddTagByIdAndTagNameApiV1ChatsIdTagsPost**](ChatsApi.md#addtagbyidandtagnameapiv1chatsidtagspost) | **POST** /api/v1/chats/{id}/tags | Add Tag By Id And Tag Name |
| [**ArchiveAllChatsApiV1ChatsArchiveAllPost**](ChatsApi.md#archiveallchatsapiv1chatsarchiveallpost) | **POST** /api/v1/chats/archive/all | Archive All Chats |
| [**ArchiveChatByIdApiV1ChatsIdArchivePost**](ChatsApi.md#archivechatbyidapiv1chatsidarchivepost) | **POST** /api/v1/chats/{id}/archive | Archive Chat By Id |
| [**CloneChatByIdApiV1ChatsIdClonePost**](ChatsApi.md#clonechatbyidapiv1chatsidclonepost) | **POST** /api/v1/chats/{id}/clone | Clone Chat By Id |
| [**CloneSharedChatByIdApiV1ChatsIdCloneSharedPost**](ChatsApi.md#clonesharedchatbyidapiv1chatsidclonesharedpost) | **POST** /api/v1/chats/{id}/clone/shared | Clone Shared Chat By Id |
| [**CreateNewChatApiV1ChatsNewPost**](ChatsApi.md#createnewchatapiv1chatsnewpost) | **POST** /api/v1/chats/new | Create New Chat |
| [**DeleteAllTagsByIdApiV1ChatsIdTagsAllDelete**](ChatsApi.md#deletealltagsbyidapiv1chatsidtagsalldelete) | **DELETE** /api/v1/chats/{id}/tags/all | Delete All Tags By Id |
| [**DeleteAllUserChatsApiV1ChatsDelete**](ChatsApi.md#deletealluserchatsapiv1chatsdelete) | **DELETE** /api/v1/chats/ | Delete All User Chats |
| [**DeleteChatByIdApiV1ChatsIdDelete**](ChatsApi.md#deletechatbyidapiv1chatsiddelete) | **DELETE** /api/v1/chats/{id} | Delete Chat By Id |
| [**DeleteSharedChatByIdApiV1ChatsIdShareDelete**](ChatsApi.md#deletesharedchatbyidapiv1chatsidsharedelete) | **DELETE** /api/v1/chats/{id}/share | Delete Shared Chat By Id |
| [**DeleteTagByIdAndTagNameApiV1ChatsIdTagsDelete**](ChatsApi.md#deletetagbyidandtagnameapiv1chatsidtagsdelete) | **DELETE** /api/v1/chats/{id}/tags | Delete Tag By Id And Tag Name |
| [**GetAllUserChatsInDbApiV1ChatsAllDbGet**](ChatsApi.md#getalluserchatsindbapiv1chatsalldbget) | **GET** /api/v1/chats/all/db | Get All User Chats In Db |
| [**GetAllUserTagsApiV1ChatsAllTagsGet**](ChatsApi.md#getallusertagsapiv1chatsalltagsget) | **GET** /api/v1/chats/all/tags | Get All User Tags |
| [**GetArchivedSessionUserChatListApiV1ChatsArchivedGet**](ChatsApi.md#getarchivedsessionuserchatlistapiv1chatsarchivedget) | **GET** /api/v1/chats/archived | Get Archived Session User Chat List |
| [**GetChatByIdApiV1ChatsIdGet**](ChatsApi.md#getchatbyidapiv1chatsidget) | **GET** /api/v1/chats/{id} | Get Chat By Id |
| [**GetChatTagsByIdApiV1ChatsIdTagsGet**](ChatsApi.md#getchattagsbyidapiv1chatsidtagsget) | **GET** /api/v1/chats/{id}/tags | Get Chat Tags By Id |
| [**GetChatsByFolderIdApiV1ChatsFolderFolderIdGet**](ChatsApi.md#getchatsbyfolderidapiv1chatsfolderfolderidget) | **GET** /api/v1/chats/folder/{folder_id} | Get Chats By Folder Id |
| [**GetPinnedStatusByIdApiV1ChatsIdPinnedGet**](ChatsApi.md#getpinnedstatusbyidapiv1chatsidpinnedget) | **GET** /api/v1/chats/{id}/pinned | Get Pinned Status By Id |
| [**GetSessionUserChatListApiV1ChatsGet**](ChatsApi.md#getsessionuserchatlistapiv1chatsget) | **GET** /api/v1/chats/ | Get Session User Chat List |
| [**GetSessionUserChatListApiV1ChatsListGet**](ChatsApi.md#getsessionuserchatlistapiv1chatslistget) | **GET** /api/v1/chats/list | Get Session User Chat List |
| [**GetSharedChatByIdApiV1ChatsShareShareIdGet**](ChatsApi.md#getsharedchatbyidapiv1chatsshareshareidget) | **GET** /api/v1/chats/share/{share_id} | Get Shared Chat By Id |
| [**GetUserArchivedChatsApiV1ChatsAllArchivedGet**](ChatsApi.md#getuserarchivedchatsapiv1chatsallarchivedget) | **GET** /api/v1/chats/all/archived | Get User Archived Chats |
| [**GetUserChatListByTagNameApiV1ChatsTagsPost**](ChatsApi.md#getuserchatlistbytagnameapiv1chatstagspost) | **POST** /api/v1/chats/tags | Get User Chat List By Tag Name |
| [**GetUserChatListByUserIdApiV1ChatsListUserUserIdGet**](ChatsApi.md#getuserchatlistbyuseridapiv1chatslistuseruseridget) | **GET** /api/v1/chats/list/user/{user_id} | Get User Chat List By User Id |
| [**GetUserChatsApiV1ChatsAllGet**](ChatsApi.md#getuserchatsapiv1chatsallget) | **GET** /api/v1/chats/all | Get User Chats |
| [**GetUserPinnedChatsApiV1ChatsPinnedGet**](ChatsApi.md#getuserpinnedchatsapiv1chatspinnedget) | **GET** /api/v1/chats/pinned | Get User Pinned Chats |
| [**ImportChatApiV1ChatsImportPost**](ChatsApi.md#importchatapiv1chatsimportpost) | **POST** /api/v1/chats/import | Import Chat |
| [**PinChatByIdApiV1ChatsIdPinPost**](ChatsApi.md#pinchatbyidapiv1chatsidpinpost) | **POST** /api/v1/chats/{id}/pin | Pin Chat By Id |
| [**SearchUserChatsApiV1ChatsSearchGet**](ChatsApi.md#searchuserchatsapiv1chatssearchget) | **GET** /api/v1/chats/search | Search User Chats |
| [**SendChatMessageEventByIdApiV1ChatsIdMessagesMessageIdEventPost**](ChatsApi.md#sendchatmessageeventbyidapiv1chatsidmessagesmessageideventpost) | **POST** /api/v1/chats/{id}/messages/{message_id}/event | Send Chat Message Event By Id |
| [**ShareChatByIdApiV1ChatsIdSharePost**](ChatsApi.md#sharechatbyidapiv1chatsidsharepost) | **POST** /api/v1/chats/{id}/share | Share Chat By Id |
| [**UpdateChatByIdApiV1ChatsIdPost**](ChatsApi.md#updatechatbyidapiv1chatsidpost) | **POST** /api/v1/chats/{id} | Update Chat By Id |
| [**UpdateChatFolderIdByIdApiV1ChatsIdFolderPost**](ChatsApi.md#updatechatfolderidbyidapiv1chatsidfolderpost) | **POST** /api/v1/chats/{id}/folder | Update Chat Folder Id By Id |
| [**UpdateChatMessageByIdApiV1ChatsIdMessagesMessageIdPost**](ChatsApi.md#updatechatmessagebyidapiv1chatsidmessagesmessageidpost) | **POST** /api/v1/chats/{id}/messages/{message_id} | Update Chat Message By Id |

<a id="addtagbyidandtagnameapiv1chatsidtagspost"></a>
# **AddTagByIdAndTagNameApiV1ChatsIdTagsPost**
> List&lt;TagModel&gt; AddTagByIdAndTagNameApiV1ChatsIdTagsPost (string id, TagForm tagForm)

Add Tag By Id And Tag Name


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **tagForm** | [**TagForm**](TagForm.md) |  |  |

### Return type

[**List&lt;TagModel&gt;**](TagModel.md)

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

<a id="archiveallchatsapiv1chatsarchiveallpost"></a>
# **ArchiveAllChatsApiV1ChatsArchiveAllPost**
> bool ArchiveAllChatsApiV1ChatsArchiveAllPost ()

Archive All Chats


### Parameters
This endpoint does not need any parameter.
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="archivechatbyidapiv1chatsidarchivepost"></a>
# **ArchiveChatByIdApiV1ChatsIdArchivePost**
> ChatResponse ArchiveChatByIdApiV1ChatsIdArchivePost (string id)

Archive Chat By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="clonechatbyidapiv1chatsidclonepost"></a>
# **CloneChatByIdApiV1ChatsIdClonePost**
> ChatResponse CloneChatByIdApiV1ChatsIdClonePost (string id, CloneForm cloneForm)

Clone Chat By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **cloneForm** | [**CloneForm**](CloneForm.md) |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="clonesharedchatbyidapiv1chatsidclonesharedpost"></a>
# **CloneSharedChatByIdApiV1ChatsIdCloneSharedPost**
> ChatResponse CloneSharedChatByIdApiV1ChatsIdCloneSharedPost (string id)

Clone Shared Chat By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="createnewchatapiv1chatsnewpost"></a>
# **CreateNewChatApiV1ChatsNewPost**
> ChatResponse CreateNewChatApiV1ChatsNewPost (ChatForm chatForm)

Create New Chat


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatForm** | [**ChatForm**](ChatForm.md) |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="deletealltagsbyidapiv1chatsidtagsalldelete"></a>
# **DeleteAllTagsByIdApiV1ChatsIdTagsAllDelete**
> bool DeleteAllTagsByIdApiV1ChatsIdTagsAllDelete (string id)

Delete All Tags By Id


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

<a id="deletealluserchatsapiv1chatsdelete"></a>
# **DeleteAllUserChatsApiV1ChatsDelete**
> bool DeleteAllUserChatsApiV1ChatsDelete ()

Delete All User Chats


### Parameters
This endpoint does not need any parameter.
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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletechatbyidapiv1chatsiddelete"></a>
# **DeleteChatByIdApiV1ChatsIdDelete**
> bool DeleteChatByIdApiV1ChatsIdDelete (string id)

Delete Chat By Id


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

<a id="deletesharedchatbyidapiv1chatsidsharedelete"></a>
# **DeleteSharedChatByIdApiV1ChatsIdShareDelete**
> bool DeleteSharedChatByIdApiV1ChatsIdShareDelete (string id)

Delete Shared Chat By Id


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

<a id="deletetagbyidandtagnameapiv1chatsidtagsdelete"></a>
# **DeleteTagByIdAndTagNameApiV1ChatsIdTagsDelete**
> List&lt;TagModel&gt; DeleteTagByIdAndTagNameApiV1ChatsIdTagsDelete (string id, TagForm tagForm)

Delete Tag By Id And Tag Name


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **tagForm** | [**TagForm**](TagForm.md) |  |  |

### Return type

[**List&lt;TagModel&gt;**](TagModel.md)

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

<a id="getalluserchatsindbapiv1chatsalldbget"></a>
# **GetAllUserChatsInDbApiV1ChatsAllDbGet**
> List&lt;ChatResponse&gt; GetAllUserChatsInDbApiV1ChatsAllDbGet ()

Get All User Chats In Db


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ChatResponse&gt;**](ChatResponse.md)

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

<a id="getallusertagsapiv1chatsalltagsget"></a>
# **GetAllUserTagsApiV1ChatsAllTagsGet**
> List&lt;TagModel&gt; GetAllUserTagsApiV1ChatsAllTagsGet ()

Get All User Tags


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;TagModel&gt;**](TagModel.md)

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

<a id="getarchivedsessionuserchatlistapiv1chatsarchivedget"></a>
# **GetArchivedSessionUserChatListApiV1ChatsArchivedGet**
> List&lt;ChatTitleIdResponse&gt; GetArchivedSessionUserChatListApiV1ChatsArchivedGet (int page = null, string query = null, string orderBy = null, string direction = null)

Get Archived Session User Chat List


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **direction** | **string** |  | [optional]  |

### Return type

[**List&lt;ChatTitleIdResponse&gt;**](ChatTitleIdResponse.md)

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

<a id="getchatbyidapiv1chatsidget"></a>
# **GetChatByIdApiV1ChatsIdGet**
> ChatResponse GetChatByIdApiV1ChatsIdGet (string id)

Get Chat By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="getchattagsbyidapiv1chatsidtagsget"></a>
# **GetChatTagsByIdApiV1ChatsIdTagsGet**
> List&lt;TagModel&gt; GetChatTagsByIdApiV1ChatsIdTagsGet (string id)

Get Chat Tags By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**List&lt;TagModel&gt;**](TagModel.md)

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

<a id="getchatsbyfolderidapiv1chatsfolderfolderidget"></a>
# **GetChatsByFolderIdApiV1ChatsFolderFolderIdGet**
> List&lt;ChatResponse&gt; GetChatsByFolderIdApiV1ChatsFolderFolderIdGet (string folderId)

Get Chats By Folder Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **folderId** | **string** |  |  |

### Return type

[**List&lt;ChatResponse&gt;**](ChatResponse.md)

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

<a id="getpinnedstatusbyidapiv1chatsidpinnedget"></a>
# **GetPinnedStatusByIdApiV1ChatsIdPinnedGet**
> bool GetPinnedStatusByIdApiV1ChatsIdPinnedGet (string id)

Get Pinned Status By Id


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

<a id="getsessionuserchatlistapiv1chatsget"></a>
# **GetSessionUserChatListApiV1ChatsGet**
> List&lt;ChatTitleIdResponse&gt; GetSessionUserChatListApiV1ChatsGet (int page = null)

Get Session User Chat List


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** |  | [optional]  |

### Return type

[**List&lt;ChatTitleIdResponse&gt;**](ChatTitleIdResponse.md)

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

<a id="getsessionuserchatlistapiv1chatslistget"></a>
# **GetSessionUserChatListApiV1ChatsListGet**
> List&lt;ChatTitleIdResponse&gt; GetSessionUserChatListApiV1ChatsListGet (int page = null)

Get Session User Chat List


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int** |  | [optional]  |

### Return type

[**List&lt;ChatTitleIdResponse&gt;**](ChatTitleIdResponse.md)

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

<a id="getsharedchatbyidapiv1chatsshareshareidget"></a>
# **GetSharedChatByIdApiV1ChatsShareShareIdGet**
> ChatResponse GetSharedChatByIdApiV1ChatsShareShareIdGet (string shareId)

Get Shared Chat By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shareId** | **string** |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="getuserarchivedchatsapiv1chatsallarchivedget"></a>
# **GetUserArchivedChatsApiV1ChatsAllArchivedGet**
> List&lt;ChatResponse&gt; GetUserArchivedChatsApiV1ChatsAllArchivedGet ()

Get User Archived Chats


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ChatResponse&gt;**](ChatResponse.md)

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

<a id="getuserchatlistbytagnameapiv1chatstagspost"></a>
# **GetUserChatListByTagNameApiV1ChatsTagsPost**
> List&lt;ChatTitleIdResponse&gt; GetUserChatListByTagNameApiV1ChatsTagsPost (TagFilterForm tagFilterForm)

Get User Chat List By Tag Name


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagFilterForm** | [**TagFilterForm**](TagFilterForm.md) |  |  |

### Return type

[**List&lt;ChatTitleIdResponse&gt;**](ChatTitleIdResponse.md)

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

<a id="getuserchatlistbyuseridapiv1chatslistuseruseridget"></a>
# **GetUserChatListByUserIdApiV1ChatsListUserUserIdGet**
> List&lt;ChatTitleIdResponse&gt; GetUserChatListByUserIdApiV1ChatsListUserUserIdGet (string userId, int page = null, string query = null, string orderBy = null, string direction = null)

Get User Chat List By User Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **page** | **int** |  | [optional]  |
| **query** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **direction** | **string** |  | [optional]  |

### Return type

[**List&lt;ChatTitleIdResponse&gt;**](ChatTitleIdResponse.md)

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

<a id="getuserchatsapiv1chatsallget"></a>
# **GetUserChatsApiV1ChatsAllGet**
> List&lt;ChatResponse&gt; GetUserChatsApiV1ChatsAllGet ()

Get User Chats


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ChatResponse&gt;**](ChatResponse.md)

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

<a id="getuserpinnedchatsapiv1chatspinnedget"></a>
# **GetUserPinnedChatsApiV1ChatsPinnedGet**
> List&lt;ChatTitleIdResponse&gt; GetUserPinnedChatsApiV1ChatsPinnedGet ()

Get User Pinned Chats


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;ChatTitleIdResponse&gt;**](ChatTitleIdResponse.md)

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

<a id="importchatapiv1chatsimportpost"></a>
# **ImportChatApiV1ChatsImportPost**
> ChatResponse ImportChatApiV1ChatsImportPost (ChatImportForm chatImportForm)

Import Chat


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **chatImportForm** | [**ChatImportForm**](ChatImportForm.md) |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="pinchatbyidapiv1chatsidpinpost"></a>
# **PinChatByIdApiV1ChatsIdPinPost**
> ChatResponse PinChatByIdApiV1ChatsIdPinPost (string id)

Pin Chat By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="searchuserchatsapiv1chatssearchget"></a>
# **SearchUserChatsApiV1ChatsSearchGet**
> List&lt;ChatTitleIdResponse&gt; SearchUserChatsApiV1ChatsSearchGet (string text, int page = null)

Search User Chats


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **text** | **string** |  |  |
| **page** | **int** |  | [optional]  |

### Return type

[**List&lt;ChatTitleIdResponse&gt;**](ChatTitleIdResponse.md)

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

<a id="sendchatmessageeventbyidapiv1chatsidmessagesmessageideventpost"></a>
# **SendChatMessageEventByIdApiV1ChatsIdMessagesMessageIdEventPost**
> bool SendChatMessageEventByIdApiV1ChatsIdMessagesMessageIdEventPost (string id, string messageId, EventForm eventForm)

Send Chat Message Event By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **messageId** | **string** |  |  |
| **eventForm** | [**EventForm**](EventForm.md) |  |  |

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

<a id="sharechatbyidapiv1chatsidsharepost"></a>
# **ShareChatByIdApiV1ChatsIdSharePost**
> ChatResponse ShareChatByIdApiV1ChatsIdSharePost (string id)

Share Chat By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="updatechatbyidapiv1chatsidpost"></a>
# **UpdateChatByIdApiV1ChatsIdPost**
> ChatResponse UpdateChatByIdApiV1ChatsIdPost (string id, ChatForm chatForm)

Update Chat By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **chatForm** | [**ChatForm**](ChatForm.md) |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="updatechatfolderidbyidapiv1chatsidfolderpost"></a>
# **UpdateChatFolderIdByIdApiV1ChatsIdFolderPost**
> ChatResponse UpdateChatFolderIdByIdApiV1ChatsIdFolderPost (string id, ChatFolderIdForm chatFolderIdForm)

Update Chat Folder Id By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **chatFolderIdForm** | [**ChatFolderIdForm**](ChatFolderIdForm.md) |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

<a id="updatechatmessagebyidapiv1chatsidmessagesmessageidpost"></a>
# **UpdateChatMessageByIdApiV1ChatsIdMessagesMessageIdPost**
> ChatResponse UpdateChatMessageByIdApiV1ChatsIdMessagesMessageIdPost (string id, string messageId, OpenWebuiRoutersChatsMessageForm openWebuiRoutersChatsMessageForm)

Update Chat Message By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **messageId** | **string** |  |  |
| **openWebuiRoutersChatsMessageForm** | [**OpenWebuiRoutersChatsMessageForm**](OpenWebuiRoutersChatsMessageForm.md) |  |  |

### Return type

[**ChatResponse**](ChatResponse.md)

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

