import { Injectable } from '@angular/core';

export interface DrawGame {
  id: string;
  title: string;
}

const DRAWGAMES: DrawGame[] = [
  { id: '111', title: 'Power 6/55' },
  { id: '222', title: 'Mega 6/45' },
  { id: '222', title: 'Max 4D' }
];

@Injectable()
export class DrawGames {
  getDrawGames(): DrawGame[] {
    return DRAWGAMES;
  }

}
