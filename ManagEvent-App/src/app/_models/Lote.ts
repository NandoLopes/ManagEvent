import { Identifiers } from "@angular/compiler"

export interface Lote {
    identifiers: number;
    nomeIdentifiers: string;
    precoIdentifiers: number;
    dataInicioIdentifiers?: Date;
    dataFimIdentifiers?: Date;
    quantidadeIdentifiers: number;
    eventoIdentifiers: number;
}
