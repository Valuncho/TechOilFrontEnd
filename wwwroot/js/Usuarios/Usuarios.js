var token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJ3ZWJBcGlTdWJqZWN0IiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZW1haWxhZGRyZXNzIjoiYWRtaW5AZ21haWwuY29tIiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZWlkZW50aWZpZXIiOiIxIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW5pc3RyYXRvciIsImV4cCI6MTY5ODk2MTExMX0.u6ZwJ33zPIVyVHaJ6ptW0YWr0M_3guUkl2TT7AAUoZk";


let table = new DataTable('#users', {
    ajax: {
        url: `https://localhost:7055/api/User`,
        dataSrc: "data",
        headers: { "Authorization": "Bearer " + token }
    },
   
    columns: [
        { data: 'userId', title: 'usuario id' },
        { data: 'name', title: 'nombre' },
        { data: 'email', title: 'mail' },
        { data: 'dni', title: 'dni' },
        { data: 'userType', title: 'tipo'}
    ]
});