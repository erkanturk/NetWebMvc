import { useEffect, useState } from 'react'
import axios from 'axios'
import './App.css'
const Api_Url='https://localhost:7029/api/Product/GetProducts'
function App() {
 const [products,setProducts]=useState([])
 const[loading,setLoading]=useState(true)
 const[error,setError]=useState(null)

 useEffect(()=>{
  axios.get(Api_Url,{params:{page:1,pageSize:10}})
  .then((res)=>setProducts(res.data))
  .catch((e)=>setError(e.message))
  .finally(()=>setLoading(false))
 },[])
 if(loading) return<p>Yükleniyor...</p>
 if(error) return<p>Hata:{error}</p>
 if(products.length===0) return<p>Ürün yok</p>

  return (
   <>
   <h1>Ürünler ({products.length})</h1>
   {products.map((product)=>(
    <div key={product.id}>
      <h3>{product.title}</h3>
      <p>{product.description}</p>
      <p>
        {product.price}$. {product.category}
      </p>
      <div>
        <img src={product.thumbnail}/>
      </div>
    </div>
   ))}
   </>
  )
}

export default App
