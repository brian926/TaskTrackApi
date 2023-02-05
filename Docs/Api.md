# Task Tracker API

- [Buber Task API](#task-tracker-api)
  - [Create Task](#create-task)
    - [Create Task Request](#create-task-request)
    - [Create Task Response](#create-task-response)
  - [Get Task](#get-task)
    - [Get Task Request](#get-task-request)
    - [Get Tasks Response](#get-task-response)
  - [Update Tasks](#update-task)
    - [Update Tasks Request](#update-task-request)
    - [Update Tasks Response](#update-task-response)
  - [Delete Tasks](#delete-task)
    - [Delete Tasks Request](#delete-task-request)
    - [Delete Tasks Response](#delete-task-response)

## Create Task

### Create Task Request

```js
POST /tasks
```

```json
{
    "name": "Make Breakfast",
    "description": "Vegan everything! Make a vegan breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "reminder": true
}
```

### Create Task Response

```js
201 Created
```

```yml
Location: {{host}}/tasks/{{id}}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Make Breakfast",
    "description": "Vegan everything! Make a vegan breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "reminder": true
}
```

## Get Task

### Get Task Request

```js
GET /tasks/{{id}}
```

### Get Task Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Make Breakfast",
    "description": "Vegan everything! Make a vegan breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "reminder": true
}
```

## Update Task

### Update Task Request

```js
PUT /tasks/{{id}}
```

```json
{
    "name": "Make Breakfast",
    "description": "Vegan everything! Make a vegan breakfast..",
    "startDateTime": "2022-04-08T08:00:00",
    "endDateTime": "2022-04-08T11:00:00",
    "lastModifiedDateTime": "2022-04-06T12:00:00",
    "reminder": true
}
```

### Update Task Response

```js
204 No Content
```

or

```js
201 Created
```

```yml
Location: {{host}}/tasks/{{id}}
```

## Delete Task

### Delete Task Request

```js
DELETE /tasks/{{id}}
```

### Delete Task Response

```js
204 No Content
```
