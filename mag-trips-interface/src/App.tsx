import './App.css'
import { Button } from "@/components/ui/button"
import { Separator } from "@/components/ui/separator"
import { Heart } from 'lucide-react'
import { SearchForm } from './Form'
import { useState } from 'react'
import { LocalTable } from './Table.tsx'

export interface LocalProps {
	name: string
  country: string
	lat: number
	lon: number
	population: number
	timezone: string
	status: string
}

function App() {
  const [localData, setLocalData] = useState<LocalProps | null>(null)
  const showTable = localData?.name

  return (
    <main className='h-screen flex flex-col'>
      <nav className="h-12 w-full flex flex-row items-center justify-between px-12">
        <span className='text-3xl font-bold'>Mag Trip</span>
        <Button variant={"link"} className='hover:bg-gray-200 gap-2 group'><Heart className="h-4 w-4" /><span>Favoritos</span></Button>    
      </nav>
      <Separator className='shadow-lg'/>
      <main className='flex flex-row w-full py-8 px-12'>
        <div className='flex flex-row h-96 border border-radius rounded-lg'>
          <div className='flex flex-col w-7/12 m-4 justify-between'>
            <p className='text-4xl text-left '>Busque um lugar para iniciar a viagem dos seus sonhos!</p>
            <SearchForm onHandleSearch={setLocalData}></SearchForm>
          </div>
          <Separator orientation='vertical' className='h-full'/>
          <div className='flex flex-col flex-1 h-full justify-around'>
            {/* <div className='h-full flex flex-col justify-center items-center hover:bg-slate-200 cursor-pointer'>Pontos Turísticos</div>
            <Separator className=''/>
            <div className='h-full flex flex-col justify-center items-center hover:bg-slate-200 cursor-pointer'>Restaurantes</div>
            <Separator className=''/>
            <div className='h-full flex flex-col justify-center items-center hover:bg-slate-200 cursor-pointer'>Itinerários</div> */}
            
            {showTable ? 
            <LocalTable 
              name={localData.name}
              country={localData.country}
              lat={localData.lat}
              lon={localData.lon}
              population={localData.population}
              timezone={localData.timezone}
              status={localData.status}
            ></LocalTable> 
            :  "Ainda não há nada aqui"}
          </div>
        </div>
      </main>    
      
 

    </main>
  )
}

export default App
