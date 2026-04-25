import apiService from '/js/shared/apiService.js';

document.getElementById('btnMessageJsonAsync').addEventListener('click', async () => {
    try {
        //c1: dùng cho các ban yếu, và nhanh
        //localhost:xxx/ajaxapi/message-json-async
        //const url = '/ajaxapi/message-json-async'

        //c2: dùng cho các bạn giỏi, nhưng hơi phức tạp
        //localhost:xxx/webbanhang/ajaxapi/message-json-async
        //const url = `@Url.Action("message-json-async", "Ajaxapi")`;

        //c3: mạnh nhất dễ bảo trì nhưng khó viết code
        //không cần biết controller vì là tên duy nhất
        //lấy theo cái Name trong Route hay là httpget/httppost
        //const url = `@Url.RouteUrl("MessageJsonAsync")`;

        const url = document.getElementById('btnMessageJsonAsync').getAttribute('data-url');
        //const url = document.getElementById('btnMessageJsonAsync').dataset.url; //cách này cũng được nhưng không phổ biến bằng getAttribute
        const result = await apiService.get(url);
        document.getElementById('resultJsonAsync').textContent = result.message;
    } catch (error) {
        console.error('Error fetching message:', error);
        document.getElementById('resultJsonAsync').textContent = 'Error fetching message';
    }
});