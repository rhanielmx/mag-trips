import axios from "axios";

export const api = axios.create({
  baseURL: 'http://localhost:5007/api/v1/Local',
  headers: { 'Access-Control-Allow-Origin': '*' }
});