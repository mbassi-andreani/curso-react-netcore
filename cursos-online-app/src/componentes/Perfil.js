import React, { useEffect } from 'react'
/* useEffect trabaja cada vez que se produce un cambio dentro de las propiedades del componente */
function Perfil(props) {
    useEffect(()=> {
        document.title = props.atributo //cada vez que la propiedad atributo cambie, actualiza el titulo de la página
    }, [props.atributo])
    return (
        <div style={{background:"yellow"}}>
        Este es el perfil de {props.atributo}
        </div>
    );
}

export default Perfil;