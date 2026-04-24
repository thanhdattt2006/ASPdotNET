import apiService from '/js/shared/apiService.js';
document.getElementById('btnMessageJsonAsync').addEventListener('click',
	async () => {
		try {
			// cách 1 nhanh
			//const url1 = '/ajaxapi/message-json-async'

			// cách 2 phức tạp
			//const url2 = `@Url.Action("message-json-async", "Ajaxapi")`;

			// cách 3 mạnh nhất, dễ bảo trì
			//const url3 = `@Url.RouteUrl("MessageJsonAsync")`

			const url3 = document.getElementById('btnMessageJsonAsync').getAttribute('data-url');
			//const url3 = docutment.getElementById('btnMessageJsonAsync').dataset.url; ko phổ biến bằng getAttribute
			const result = await apiService.get(url3);
			document.getElementById('resultJsonAsync').textContent = result.message;
		} catch (error) {
			console.error('error fetch message: ', error);
			document.getElementById('resultJsonAsync').textContent = 'Error fetching message';
		}
	});