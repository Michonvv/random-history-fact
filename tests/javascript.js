fetch('https://randomhistoricalfact.000webhostapp.com/fact')
    .then(response => response.json())
    .then(data => {
        console.log(data.fact);
    })
    .catch(error => {
        console.error('Error fetching data:', error);
    });
