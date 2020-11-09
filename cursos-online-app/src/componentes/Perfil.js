import React, { useEffect, useState } from 'react'
import axios from 'axios'

/* useEffect trabaja cada vez que se produce un cambio dentro de las propiedades del componente */
function Perfil(props) {
    const [paises, obtenerPaises] = useState([]);
    const [status, cambiarStatus] = useState(false); //cuando cargues la página, no va a estar cargado

    useEffect(()=> {
        axios.get('https://restcountries.eu/rest/v2/all').then(resultado => {
            obtenerPaises(resultado.data);
            cambiarStatus(true);
        }).catch(error => {
            cambiarStatus(true);
        })
        
    }, []) //si en el segundo parámetro dejás los corchetes vacíos, el useEffect se ejecuta una sola vez porque no le pasas una propiedad para que la evalue
    if(status) {
        return (
            <ul>
               {paises.map((pais,indice) => 
               <li key={indice}>{pais.name}</li>
               )} 
            </ul>
        );
    } else {
        return (<h1>Obteniendo paises...</h1>);
    }
}

export default Perfil;