import { expect } from 'chai';
import {lookupChar} from '../charLookup.js';

describe('Character Lookup', () => {
    it('Should return character at specified index', () => {
        const result = lookupChar('Lorem', 1);
        expect(result).to.equal('o');
    })
    it('Should indicate when index is out of range', () => {
        expect(lookupChar('Lorem', -1)).to.equal('Incorrect index');
        expect(lookupChar('Lorem', 5)).to.equal('Incorrect index');
        expect(lookupChar('Lorem', 10)).to.equal('Incorrect index');
    })
    it('Should return undefined when incorrect text type is given', () => {
        expect(lookupChar(false, 1)).to.be.undefined;
        expect(lookupChar(1, 1)).to.be.undefined;
        expect(lookupChar(undefined, 1)).to.be.undefined;
        expect(lookupChar(null, 1)).to.be.undefined;
        expect(lookupChar(NaN, 1)).to.be.undefined;
        expect(lookupChar([{input: 'Lorem'}], 1)).to.be.undefined;
    })
    it('Should return undefined when incorrect index value is given', () => {
        expect(lookupChar('Foo', '')).to.be.undefined;
        expect(lookupChar('Foo', true)).to.be.undefined;
        expect(lookupChar('Foo', NaN)).to.be.undefined;
        expect(lookupChar('Foo', Infinity)).to.be.undefined;
        expect(lookupChar('Foo', null)).to.be.undefined;
        expect(lookupChar('Foo', undefined)).to.be.undefined;
        expect(lookupChar('Foo', [1])).to.be.undefined;
        expect(lookupChar('Foo', {index: 1})).to.be.undefined;
    })
});