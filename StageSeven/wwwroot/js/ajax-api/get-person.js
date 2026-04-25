import apiService from '/js/shared/apiService.js';

document.getElementById('btnSendPerson').addEventListener('click', async () => {
    const name = document.getElementById('txtFullName').value.trim();
    const age = document.getElementById('txtAge').value.trim();


    if (!name) {
        document.getElementById("resultPerson").innerHTML = "<b style='color:red'>name is required</b>";
        return;
    }

    if (!/^\d+$/.test(age)) {
        document.getElementById("resultPerson").innerHTML = "<b style='color:red'>age must be a number</b>";
        return;
    }

    var ageValue = parseInt(age);
    if (ageValue < 0 || ageValue > 150) {
        document.getElementById("resultPerson").innerHTML = "<b style='color:red'>age must be between 0 and 150</b>";
        return;
    }
    try {
      
        const url = document.getElementById('btnSendPerson').getAttribute('data-url');
        const person = { Name: name, Age: parseInt(age) };
        const result = await apiService.post(url, person);

        document.getElementById('resultPerson').textContent = `Fullname: ${result.fullname}, Age: ${result.age}`;
    } catch (error) {
        console.error('Error fetching message:', error);
        document.getElementById('resultPerson').textContent = 'Error fetching message';
    }
});