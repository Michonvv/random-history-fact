require 'net/http'
require 'json'

url = URI.parse('https://randomhistoricalfact.000webhostapp.com/fact')
response = Net::HTTP.get_response(url)

if response.code.to_i == 200
  data = JSON.parse(response.body)
  puts data['fact']
else
  puts 'Error fetching data:', response.code
end
