# Org.OpenAPITools.Api.NotesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateNewNoteApiV1NotesCreatePost**](NotesApi.md#createnewnoteapiv1notescreatepost) | **POST** /api/v1/notes/create | Create New Note |
| [**DeleteNoteByIdApiV1NotesIdDeleteDelete**](NotesApi.md#deletenotebyidapiv1notesiddeletedelete) | **DELETE** /api/v1/notes/{id}/delete | Delete Note By Id |
| [**GetNoteByIdApiV1NotesIdGet**](NotesApi.md#getnotebyidapiv1notesidget) | **GET** /api/v1/notes/{id} | Get Note By Id |
| [**GetNoteListApiV1NotesListGet**](NotesApi.md#getnotelistapiv1noteslistget) | **GET** /api/v1/notes/list | Get Note List |
| [**GetNotesApiV1NotesGet**](NotesApi.md#getnotesapiv1notesget) | **GET** /api/v1/notes/ | Get Notes |
| [**UpdateNoteByIdApiV1NotesIdUpdatePost**](NotesApi.md#updatenotebyidapiv1notesidupdatepost) | **POST** /api/v1/notes/{id}/update | Update Note By Id |

<a id="createnewnoteapiv1notescreatepost"></a>
# **CreateNewNoteApiV1NotesCreatePost**
> NoteModel CreateNewNoteApiV1NotesCreatePost (NoteForm noteForm)

Create New Note


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **noteForm** | [**NoteForm**](NoteForm.md) |  |  |

### Return type

[**NoteModel**](NoteModel.md)

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

<a id="deletenotebyidapiv1notesiddeletedelete"></a>
# **DeleteNoteByIdApiV1NotesIdDeleteDelete**
> bool DeleteNoteByIdApiV1NotesIdDeleteDelete (string id)

Delete Note By Id


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

<a id="getnotebyidapiv1notesidget"></a>
# **GetNoteByIdApiV1NotesIdGet**
> NoteModel GetNoteByIdApiV1NotesIdGet (string id)

Get Note By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**NoteModel**](NoteModel.md)

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

<a id="getnotelistapiv1noteslistget"></a>
# **GetNoteListApiV1NotesListGet**
> List&lt;NoteUserResponse&gt; GetNoteListApiV1NotesListGet ()

Get Note List


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;NoteUserResponse&gt;**](NoteUserResponse.md)

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

<a id="getnotesapiv1notesget"></a>
# **GetNotesApiV1NotesGet**
> List&lt;NoteUserResponse&gt; GetNotesApiV1NotesGet ()

Get Notes


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;NoteUserResponse&gt;**](NoteUserResponse.md)

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

<a id="updatenotebyidapiv1notesidupdatepost"></a>
# **UpdateNoteByIdApiV1NotesIdUpdatePost**
> NoteModel UpdateNoteByIdApiV1NotesIdUpdatePost (string id, NoteForm noteForm)

Update Note By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **noteForm** | [**NoteForm**](NoteForm.md) |  |  |

### Return type

[**NoteModel**](NoteModel.md)

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

