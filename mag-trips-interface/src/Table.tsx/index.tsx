import { LocalProps } from "@/App"
import {
  Table,
  TableBody,
  TableCaption,
  TableCell,
  TableHead,
  TableHeader,
  TableRow,
} from "@/components/ui/table"
import { Separator } from "@radix-ui/react-separator"



export function LocalTable(data:LocalProps) {

  return (
    <div className="flex flex-col h-screen justify-around">
      <Table>
      <TableHeader >
        <TableRow >
          <TableHead >Local</TableHead>
          <TableHead>País</TableHead>
          <TableHead>População</TableHead>
          {/* <TableHead className="text-right">Amount</TableHead> */}
        </TableRow>
      </TableHeader>
      <TableBody className="text-left">
        <TableRow>
          <TableCell className="font-medium ">{data.name}</TableCell>
          <TableCell>{data.country}</TableCell>
          <TableCell>{data.population}</TableCell>
          {/* <TableCell className="text-right">$250.00</TableCell> */}
        </TableRow>
      </TableBody>
    </Table>
    <Separator />
    <Table>
      <TableCaption>Informações adicionais</TableCaption>
      <TableHeader>
        <TableRow>
          <TableHead className="w-[100px]">Timezone</TableHead>
          <TableHead>Latitude</TableHead>
          <TableHead>Longitude</TableHead>
          {/* <TableHead className="text-right">Amount</TableHead> */}
        </TableRow>
      </TableHeader>
      <TableBody className="text-left">
        <TableRow>
          <TableCell className="font-medium">{data.timezone}</TableCell>
          <TableCell>{data.lat}</TableCell>
          <TableCell>{data.lon}</TableCell>
          {/* <TableCell className="text-right">$250.00</TableCell> */}
        </TableRow>
      </TableBody>
    </Table>
    </div>
  )
}


