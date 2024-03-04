"use client";

import { zodResolver } from "@hookform/resolvers/zod"
import { useForm } from "react-hook-form"
import { z } from "zod"

import { Button } from "@/components/ui/button"
import {
  Form,
  FormControl,
  FormDescription,
  FormField,
  FormItem,
  FormLabel,
  FormMessage,
} from "@/components/ui/form"

import { Input } from "@/components/ui/input"
import { api } from "@/lib/api"
 
const formSchema = z.object({
  local: z.string().min(2, {
    message: "Username must be at least 2 characters.",
  }),
})

interface SearchFormProps {
  onHandleSearch: (arg0: string) => void;
}
 
export function SearchForm({onHandleSearch}) {
  const form = useForm()

  const onSubmit = async (data) => {
    const response = await api.get(`/search/${data.local}`)
    onHandleSearch(response.data)
  }
 
  return (
    <Form {...form}>
      <form onSubmit={form.handleSubmit(onSubmit)} className="">
        <FormField
          control={form.control}
          name="local"
          render={({ field }) => (
            <FormItem>
              <FormLabel></FormLabel>
              <FormControl>
                <Input placeholder="Digite o nome de um lugar" {...field} />
              </FormControl>
              <FormDescription>
              </FormDescription>
              <FormMessage />
            </FormItem>
          )}
        />
        <Button type="submit">Buscar</Button>
      </form>
    </Form>
  )
}