const cargarPost = document.querySelector('#cargar').addEventListener('click', cargarApi);




function cargarApi()
{
const xhr = new XMLHttpRequest();

xhr.open('GET', 'http://localhost:5000/WeatherForecast', true )

xhr.onload = function(){
    if(this.status === 200){
      const respuesta = JSON.parse(this.responseText);

      let contenido = '';
      respuesta.forEach(function(post){
        contenido += `
        <h5>Date: ${post.date}</h5>
        <h5>temperatureC: ${post.temperatureC}</h5>
        <h5>temperatureF: ${post.temperatureF}</h5>
        <p>summary: ${post.summary}</p>
        `;

      });
      document.getElementById('listado').innerHTML = contenido;
    }
  }
xhr.send();
}

