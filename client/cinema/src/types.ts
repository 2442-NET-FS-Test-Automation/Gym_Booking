
export interface CinemaItem {
    cinema_Id: number;
    cinemaName: string;
    cinemaCity: string;
}

export type FetchState = "idle" | "loading" | "loaded" | "failed";