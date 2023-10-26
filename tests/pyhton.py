import requests

response = requests.get('https://randomhistoricalfact.000webhostapp.com/fact')
if response.status_code == 200:
    data = response.json()
    print(data['fact'])
else:
    print('Error fetching data:', response.status_code)
