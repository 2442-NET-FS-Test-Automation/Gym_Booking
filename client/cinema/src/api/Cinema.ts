import { api } from "./axios";
import type { CinemaItem } from "../types";

export async function getCinemas (): Promise<CinemaItem[]> {
    const response = await api.get<CinemaItem[]>("/api/Cinemas")
    return response.data;
}