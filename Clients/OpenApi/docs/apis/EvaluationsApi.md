# Org.OpenAPITools.Api.EvaluationsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFeedbackApiV1EvaluationsFeedbackPost**](EvaluationsApi.md#createfeedbackapiv1evaluationsfeedbackpost) | **POST** /api/v1/evaluations/feedback | Create Feedback |
| [**DeleteAllFeedbacksApiV1EvaluationsFeedbacksAllDelete**](EvaluationsApi.md#deleteallfeedbacksapiv1evaluationsfeedbacksalldelete) | **DELETE** /api/v1/evaluations/feedbacks/all | Delete All Feedbacks |
| [**DeleteFeedbackByIdApiV1EvaluationsFeedbackIdDelete**](EvaluationsApi.md#deletefeedbackbyidapiv1evaluationsfeedbackiddelete) | **DELETE** /api/v1/evaluations/feedback/{id} | Delete Feedback By Id |
| [**DeleteFeedbacksApiV1EvaluationsFeedbacksDelete**](EvaluationsApi.md#deletefeedbacksapiv1evaluationsfeedbacksdelete) | **DELETE** /api/v1/evaluations/feedbacks | Delete Feedbacks |
| [**GetAllFeedbacksApiV1EvaluationsFeedbacksAllExportGet**](EvaluationsApi.md#getallfeedbacksapiv1evaluationsfeedbacksallexportget) | **GET** /api/v1/evaluations/feedbacks/all/export | Get All Feedbacks |
| [**GetAllFeedbacksApiV1EvaluationsFeedbacksAllGet**](EvaluationsApi.md#getallfeedbacksapiv1evaluationsfeedbacksallget) | **GET** /api/v1/evaluations/feedbacks/all | Get All Feedbacks |
| [**GetConfigApiV1EvaluationsConfigGet**](EvaluationsApi.md#getconfigapiv1evaluationsconfigget) | **GET** /api/v1/evaluations/config | Get Config |
| [**GetFeedbackByIdApiV1EvaluationsFeedbackIdGet**](EvaluationsApi.md#getfeedbackbyidapiv1evaluationsfeedbackidget) | **GET** /api/v1/evaluations/feedback/{id} | Get Feedback By Id |
| [**GetFeedbacksApiV1EvaluationsFeedbacksUserGet**](EvaluationsApi.md#getfeedbacksapiv1evaluationsfeedbacksuserget) | **GET** /api/v1/evaluations/feedbacks/user | Get Feedbacks |
| [**UpdateConfigApiV1EvaluationsConfigPost**](EvaluationsApi.md#updateconfigapiv1evaluationsconfigpost) | **POST** /api/v1/evaluations/config | Update Config |
| [**UpdateFeedbackByIdApiV1EvaluationsFeedbackIdPost**](EvaluationsApi.md#updatefeedbackbyidapiv1evaluationsfeedbackidpost) | **POST** /api/v1/evaluations/feedback/{id} | Update Feedback By Id |

<a id="createfeedbackapiv1evaluationsfeedbackpost"></a>
# **CreateFeedbackApiV1EvaluationsFeedbackPost**
> FeedbackModel CreateFeedbackApiV1EvaluationsFeedbackPost (FeedbackForm feedbackForm)

Create Feedback


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **feedbackForm** | [**FeedbackForm**](FeedbackForm.md) |  |  |

### Return type

[**FeedbackModel**](FeedbackModel.md)

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

<a id="deleteallfeedbacksapiv1evaluationsfeedbacksalldelete"></a>
# **DeleteAllFeedbacksApiV1EvaluationsFeedbacksAllDelete**
> Object DeleteAllFeedbacksApiV1EvaluationsFeedbacksAllDelete ()

Delete All Feedbacks


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="deletefeedbackbyidapiv1evaluationsfeedbackiddelete"></a>
# **DeleteFeedbackByIdApiV1EvaluationsFeedbackIdDelete**
> Object DeleteFeedbackByIdApiV1EvaluationsFeedbackIdDelete (string id)

Delete Feedback By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

**Object**

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

<a id="deletefeedbacksapiv1evaluationsfeedbacksdelete"></a>
# **DeleteFeedbacksApiV1EvaluationsFeedbacksDelete**
> bool DeleteFeedbacksApiV1EvaluationsFeedbacksDelete ()

Delete Feedbacks


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

<a id="getallfeedbacksapiv1evaluationsfeedbacksallexportget"></a>
# **GetAllFeedbacksApiV1EvaluationsFeedbacksAllExportGet**
> List&lt;FeedbackModel&gt; GetAllFeedbacksApiV1EvaluationsFeedbacksAllExportGet ()

Get All Feedbacks


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FeedbackModel&gt;**](FeedbackModel.md)

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

<a id="getallfeedbacksapiv1evaluationsfeedbacksallget"></a>
# **GetAllFeedbacksApiV1EvaluationsFeedbacksAllGet**
> List&lt;FeedbackUserResponse&gt; GetAllFeedbacksApiV1EvaluationsFeedbacksAllGet ()

Get All Feedbacks


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FeedbackUserResponse&gt;**](FeedbackUserResponse.md)

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

<a id="getconfigapiv1evaluationsconfigget"></a>
# **GetConfigApiV1EvaluationsConfigGet**
> Object GetConfigApiV1EvaluationsConfigGet ()

Get Config


### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

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

<a id="getfeedbackbyidapiv1evaluationsfeedbackidget"></a>
# **GetFeedbackByIdApiV1EvaluationsFeedbackIdGet**
> FeedbackModel GetFeedbackByIdApiV1EvaluationsFeedbackIdGet (string id)

Get Feedback By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |

### Return type

[**FeedbackModel**](FeedbackModel.md)

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

<a id="getfeedbacksapiv1evaluationsfeedbacksuserget"></a>
# **GetFeedbacksApiV1EvaluationsFeedbacksUserGet**
> List&lt;FeedbackUserResponse&gt; GetFeedbacksApiV1EvaluationsFeedbacksUserGet ()

Get Feedbacks


### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;FeedbackUserResponse&gt;**](FeedbackUserResponse.md)

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

<a id="updateconfigapiv1evaluationsconfigpost"></a>
# **UpdateConfigApiV1EvaluationsConfigPost**
> Object UpdateConfigApiV1EvaluationsConfigPost (UpdateConfigForm updateConfigForm)

Update Config


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateConfigForm** | [**UpdateConfigForm**](UpdateConfigForm.md) |  |  |

### Return type

**Object**

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

<a id="updatefeedbackbyidapiv1evaluationsfeedbackidpost"></a>
# **UpdateFeedbackByIdApiV1EvaluationsFeedbackIdPost**
> FeedbackModel UpdateFeedbackByIdApiV1EvaluationsFeedbackIdPost (string id, FeedbackForm feedbackForm)

Update Feedback By Id


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** |  |  |
| **feedbackForm** | [**FeedbackForm**](FeedbackForm.md) |  |  |

### Return type

[**FeedbackModel**](FeedbackModel.md)

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

