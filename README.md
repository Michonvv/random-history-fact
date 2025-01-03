<h1 align="center">
  <img src="logo.png" alt="Random History Fact API" width="400">
</h1>

# Random History Fact API

**⚠️ IMPORTANT WARNING: The demo API endpoint `https://randomhistoricalfact.000webhostapp.com/fact` is OFFLINE and no longer works. If you wish to use this API, you must host it yourself.**

Welcome to the Random History Fact API, where you can access fascinating historical facts with ease.<br>
<a href="https://warm-teammates-951039.framer.app/">Visit the website</a>

---

## Example API Response

```json
{
    "fact": "The Bloody Mary wasn't always called Bloody Mary! First, the popular brunch drink was actually called A Bucket Of Blood. After Bucket Of Blood, it transitioned to Red Snapper and, finally, settled on Bloody Mary.",
    "source": "https://parade.com/1099930/marynliles/history-facts/"
}
```

---

## Usage
To get a random historical fact, make an HTTP GET request to the following URL:
```url
https://randomhistoricalfact.000webhostapp.com/fact
```
**⚠️ NOTE:** As mentioned above, this endpoint is no longer functional. You will need to host your own version of this API.

### Example using JavaScript
Here's how to fetch and display a random historical fact in JavaScript:

```javascript
fetch('https://randomhistoricalfact.000webhostapp.com/fact')
    .then(response => response.json())
    .then(data => {
        console.log(data.fact);
    })
    .catch(error => {
        console.error('Error fetching data:', error);
    });
```

### Example using Python
You can also access historical facts using Python:

```python
import requests

response = requests.get('https://randomhistoricalfact.000webhostapp.com/fact')
if response.status_code == 200:
    data = response.json()
    print(data['fact'])
else:
    print('Error fetching data:', response.status_code)
```

---

## Project Structure
The project is organized into two main folders:
```
src: Contains the source code for the Random History Fact API.
```
```
tests: Provides code snippets in different programming languages to help you integrate the API into your projects.
```
Feel free to explore these folders and adapt the provided code snippets for your specific use case.

---

## License
This project is open-source and available for your customization and use.
